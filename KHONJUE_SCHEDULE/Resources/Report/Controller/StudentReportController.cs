using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Schedule.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = QuestPDF.Infrastructure.Image;

namespace KHONJUE_SCHEDULE.Resources.Report.Controller
{
    class TeacherReportController : IDocument
    {

        private List<ScheduleModel> Entries;
        private List<TimePeriodModel> Periods;
        private string Type;
        public TeacherReportController(List<ScheduleModel> entries, List<TimePeriodModel> periods, string type)
        {
            Entries = entries;
            Periods = periods;
            Type = type;
        }
        public void Compose(IDocumentContainer container)
        {
            /* 1 ─────────────────────────────────────────────────────────────
               Build helpers: Lao labels and a fast lookup dictionary        */
            var laoDays = new Dictionary<DayOfWeek, string>
            {
                [DayOfWeek.Monday] = "ຈັນ",
                [DayOfWeek.Tuesday] = "ອັງຄານ",
                [DayOfWeek.Wednesday] = "ພຸດ",
                [DayOfWeek.Thursday] = "ພະຫັດ",
                [DayOfWeek.Friday] = "ສຸກ",
                [DayOfWeek.Saturday] = "ເສົາ",
                [DayOfWeek.Sunday] = "ອາທິດ"
            };
            var daysOfWeek = Enum.GetValues<DayOfWeek>().ToList();

            // All periods, sorted earliest → latest
            var sortedPeriods = Periods.OrderBy(p => p.startTime).ToList();
            string MakeKey(string day, string period) =>
    $"{day.Trim().ToLowerInvariant()}|{period.Trim().ToLowerInvariant()}";
            // Fast lookup: (Day, TimeLabel) → ScheduleModel
            var entryLookup = Entries.ToDictionary(
                e => MakeKey(e.Day, e.period),
                e => e,
                StringComparer.OrdinalIgnoreCase);
            /* 2 ─────────────────────────────────────────────────────────────
               Create the A4 page                                             */
            container.Page(page =>
            {
                page.Margin(4);
                page.Size(PageSizes.A4);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(9).FontFamily("Noto Sans Lao"));

                /* ─ Header (Logo + titles) ──────────────────────────────── */
                var logoPath = Path.GetFullPath("logo.jpeg");
                if (!File.Exists(logoPath))
                    throw new FileNotFoundException(logoPath);

                page.Header().Column(col =>
                {
                    col.Item().AlignCenter().Height(40).Image(Image.FromFile(logoPath));

                    col.Item().AlignCenter().Text("ສາທາລະນະລັດ ປະຊາທິປະໄຕ ປະຊາຊົນລາວ")
                        .FontSize(14).SemiBold();
                    col.Item().AlignCenter().Text("ສັນຕິພາບ  ເອກະລາດ  ປະຊາທິປະໄຕ  ວັດທະນາຖາວອນ")
                        .FontSize(14);

                    col.Item().Text("1. ຕາຕະລາງຮຽນປະຈໍາອາທິດ")
                        .FontSize(12).AlignLeft();
                });

                /* ─ Grid timetable ──────────────────────────────────────── */
                page.Content().Table(table =>
                {
                    // Column definitions: 1 for time label, N for days
                    table.ColumnsDefinition(cols =>
                    {
                        cols.RelativeColumn(1);            // Time / Period
                        foreach (var _ in daysOfWeek)
                            cols.RelativeColumn(1);        // One per day
                    });

                    /* Header row (days) */
                    table.Header(h =>
                    {
                        // First (empty) cell for the vertical "Time" column
                        h.Cell().Element(HeadStyle).AlignCenter()
                            .Text("ເວລາ");

                        foreach (var d in daysOfWeek)
                            h.Cell().Element(HeadStyle).AlignCenter()
                             .Text(laoDays[d]);

                        static IContainer HeadStyle(IContainer c) =>
                            c.Background(Colors.Grey.Lighten2)
                             .Border(1)
                             .BorderColor(Colors.Grey.Darken2)
                             .DefaultTextStyle(x => x.SemiBold());
                    });

                    /* Data rows: one per defined TimePeriod */
                    foreach (var p in sortedPeriods)
                    {
                        var timeLabel = $"{p.startTime:hh\\:mm} - {p.endTime:hh\\:mm}";

                        // Left‑most cell: time range
                        table.Cell().Element(RowStyle).Text(timeLabel);

                        // One cell per day
                        foreach (var day in daysOfWeek)
                        {
                            entryLookup.TryGetValue(MakeKey(day.ToString(), timeLabel), out var entry);

                            table.Cell().Element(RowStyle).AlignCenter().Text(entry is null
                                ? ""
                                : $"ວິຊາ: {entry.subjectName}\n ອາຈານ: {entry.TeacherName}\n ຫ້ອງ: {entry.RoomName}\n {(Type.Equals("student") ? "ຫ້ອງສາຂາ: " + entry.majorName + "(" + entry.ClassName +")" : "")}");
                        }
                    }

                    static IContainer RowStyle(IContainer c) =>
                        c
                         .Border(1)
                         .BorderColor(Colors.Grey.Lighten1);
                });

                /* ─ Footer ─────────────────────────────────────────────── */
                page.Footer().AlignCenter()
                    .Text($"Generated on {DateTime.Now:yyyy-MM-dd HH:mm}")
                    .FontSize(10)
                    .FontColor(Colors.Grey.Darken1);
            });
        }


    }
}