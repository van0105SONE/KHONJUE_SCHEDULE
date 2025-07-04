using KHONJUE_SCHEDULE.Resources.Schedule.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Report.Controller
{
    class TeacherReportController : IDocument
    {

        private List<ScheduleModel> Entries;

        public TeacherReportController(List<ScheduleModel> entries)
        {
            Entries = entries;
        }
        public void Compose(IDocumentContainer container)
        {
            this.Entries = this.Entries.OrderByDescending(t => t.Day).ToList() ;
            container.Page(page =>
            {
                page.Margin(10);
                page.Size(PageSizes.A4);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10));
                var physical = Path.GetFullPath("WhatsApp Image 2025-05-03 at 13.52.37.jpeg");
                if (!File.Exists(physical))
                    throw new FileNotFoundException(physical);
                page.Header().Column(column =>
                {
                    column.Item().AlignCenter().Height(40).Image(QuestPDF.Infrastructure.Image.FromFile(physical));
                    column.Item().Text("ສາທາລະນະລັດ ປະຊາທິປະໄຕ ປະຊາຊົນລາວ")
                        .FontFamily("Noto Sans Lao")
                        .FontSize(14).AlignCenter();
                    column.Item().Text("ສັນຕິພາບ ເອກະລາດ ປະຊາທິປະໄຕ ວັດທະນາຖາວອນ")
      .FontFamily("Noto Sans Lao")
      .FontSize(14).AlignCenter();

                    column.Item().Text("1.ລາຍງານຕາຕະລາງຮຽນ")
                        .FontFamily("Noto Sans Lao")
                        .FontSize(12).AlignLeft();
                });


                page.Content().Table(table =>
                {
                    // Define columns
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(1); // Day
                        columns.RelativeColumn(1); // Period
                        columns.RelativeColumn(1); // Subject
                        columns.RelativeColumn(1); // Teacher
                        columns.RelativeColumn(1); // Room
                        columns.RelativeColumn(1); // Major
                        columns.RelativeColumn(1); // Major
                    });


                    // Header row
                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).AlignCenter().Text("ມື້").Bold().FontFamily("Noto Sans Lao");
                        header.Cell().Element(CellStyle).AlignCenter().Text("ເວລາ").Bold().FontFamily("Noto Sans Lao");
                        header.Cell().Element(CellStyle).AlignCenter().Text("ວິຊາ").Bold().FontFamily("Noto Sans Lao");
                        header.Cell().Element(CellStyle).AlignCenter().Text("ປິ").Bold().FontFamily("Noto Sans Lao");
                        header.Cell().Element(CellStyle).AlignCenter().Text("ຫ້ອງຮຽນ").Bold().FontFamily("Noto Sans Lao");
                        header.Cell().Element(CellStyle).AlignCenter().Text("ສາຂາ").Bold().FontFamily("Noto Sans Lao");
                        header.Cell().Element(CellStyle).AlignCenter().Text("ອາຈານ").Bold().FontFamily("Noto Sans Lao");
                        static IContainer CellStyle(IContainer container)
                        {
                            return container
                                .DefaultTextStyle(x => x.SemiBold())
                                .Padding(0)
                                .Background(Colors.Grey.Lighten2)
                                .Border(1)
                                .BorderColor(Colors.Grey.Darken2);
                        }
                    });

                    // Data rows
                    foreach (var entry in Entries)
                    {
                        table.Cell().Element(CellStyle).Text(entry.Day);
                        table.Cell().Element(CellStyle).Text(entry.period);
                        table.Cell().Element(CellStyle).Text(entry.subjectName);
                        table.Cell().Element(CellStyle).Text(entry.levelName);
                        table.Cell().Element(CellStyle).Text(entry.RoomName);
                        table.Cell().Element(CellStyle).Text(entry.majorName);
                        table.Cell().Element(CellStyle).Text(entry.TeacherName);
                        static IContainer CellStyle(IContainer container)
                        {
                            return container
                                .Padding(5)
                                .BorderBottom(1)
                                .BorderColor(Colors.Grey.Lighten2);
                        }
                    }
                });

                page.Footer()
                    .AlignCenter()
                    .Text($"Generated on {DateTime.Now}")
                    .FontSize(10)
                    .FontColor(Colors.Grey.Darken1);
            });
        }
    }
}