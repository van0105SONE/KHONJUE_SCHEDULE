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

namespace KHONJUE_SCHEDULE.Resources.Report.Controller
{
    class RoomReportController : IDocument
    {

        private List<StudentClassModel> Entries;

        public RoomReportController(List<StudentClassModel> entries)
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
                    .Text("ລາຍງານຫ້ອງຮຽນ").Bold()
                    .FontSize(12);

                page.Content().Table(table =>
                {
                    // Define columns
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(2); // Day
                        columns.RelativeColumn(1); // Period
                        columns.RelativeColumn(1); // Subject
                        columns.RelativeColumn(2); // Subject

                    });


                    // Header row
                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).AlignCenter().Text("ລະຫັດຫ້ອງ").Bold();
                        header.Cell().Element(CellStyle).AlignCenter().Text("ຊື່ຫ້ອງ").Bold();
                        header.Cell().Element(CellStyle).AlignCenter().Text("ປະເພດຫ້ອງ").Bold();
                        header.Cell().Element(CellStyle).AlignCenter().Text("ຄຳອະທິບາຍ").Bold();



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
                        table.Cell().Element(CellStyle).Text(entry.Code);
                        table.Cell().Element(CellStyle).Text(entry.StudentClassName);
                        table.Cell().Element(CellStyle).Text(entry.RoomType);
                        table.Cell().Element(CellStyle).Text(entry.Description);
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
