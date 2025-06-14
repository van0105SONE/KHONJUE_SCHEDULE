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
    class RoomScheduleReportController : IDocument
    {

        private List<ScheduleModel> Entries;

        public RoomScheduleReportController(List<ScheduleModel> entries)
        {
            Entries = entries ;
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(10);
                page.Size(PageSizes.A4);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Header().AlignCenter()
                    .Text("ລາຍງານຊົ່ວໂມງຂື້ນສອນອາຈານ").Bold()
                    .FontSize(12);

                page.Content().Table(table =>
                {
                    // Define columns
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(1); // Day
                        columns.RelativeColumn(2); // Period
                        columns.RelativeColumn(1); // Subject


                    });


                    // Header row
                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).AlignCenter().Text("ມື້").Bold();
                        header.Cell().Element(CellStyle).AlignCenter().Text("ເວລາ").Bold();
                        header.Cell().Element(CellStyle).AlignCenter().Text("ຫ້ອງຮຽນ").Bold();



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
                        table.Cell().Element(CellStyle).Text(entry.Day);
                        table.Cell().Element(CellStyle).Text(entry.period);
                        table.Cell().Element(CellStyle).Text(entry.RoomName);

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
