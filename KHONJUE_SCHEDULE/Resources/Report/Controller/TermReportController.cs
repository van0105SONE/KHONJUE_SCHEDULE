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
    class TermReportController : IDocument
    {
        private List<TermModel> Entries;

        public TermReportController(List<TermModel> entries)
        {
            Entries = entries;
        }
        public void Compose(IDocumentContainer container)
        {
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
                    column.Item().AlignCenter().Height(40).Image(Image.FromFile(physical));
                    column.Item().Text("ສາທາລະນະລັດ ປະຊາທິປະໄຕ ປະຊາຊົນລາວ")
                        .FontFamily("Noto Sans Lao")
                        .FontSize(14).AlignCenter();
                    column.Item().Text("ສັນຕິພາບ ເອກະລາດ ປະຊາທິປະໄຕ ວັດທະນາຖາວອນ")
      .FontFamily("Noto Sans Lao")
      .FontSize(14).AlignCenter();

                    column.Item().Text("1.ລາຍງານພາກຮຽນ")
                        .FontFamily("Noto Sans Lao")
                        .FontSize(12).AlignLeft();
                });


                page.Content().Table(table =>
                {
                    // Define columns
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(1); // Day
                        columns.RelativeColumn(2); // Period

                    });


                    // Header row
                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).AlignCenter().Text("ລະຫັດພາກຮຽນ").Bold().FontFamily("Noto Sans Lao");
                        header.Cell().Element(CellStyle).AlignCenter().Text("ຊືພາກຮຽນ").Bold().FontFamily("Noto Sans Lao");

                        static IContainer CellStyle(IContainer container)
                        {
                            return container
                                .DefaultTextStyle(x => x.SemiBold())
                                .Padding(5)
                                .Background(Colors.Grey.Lighten2)
                                .Border(1)
                                .BorderColor(Colors.Grey.Darken2);
                        }
                    });

                    // Data rows
                    foreach (var entry in Entries)
                    {
                        table.Cell().Element(CellStyle).Text(entry.TermCode);
                        table.Cell().Element(CellStyle).Text(entry.TermName);
     


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
