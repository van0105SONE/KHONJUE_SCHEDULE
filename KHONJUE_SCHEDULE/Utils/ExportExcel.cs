using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Utils
{
    using ClosedXML.Excel;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public static class ExcelExport
    {
        /// <summary>
        /// Exports any IEnumerable<T> to an .xlsx file on the user’s Desktop.
        /// Header names = property names; order = declared order in the class.
        /// </summary>
        public static void ToExcelClosedXml<T>(IEnumerable<T> data, string fileName = "Export.xlsx")
        {
            var props = typeof(T).GetProperties(
                BindingFlags.Public | BindingFlags.Instance);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktop, fileName);

            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Data");

            // 1. headers
            for (int c = 0; c < props.Length; c++)
                ws.Cell(1, c + 1).Value = props[c].Name;

            // 2. rows
            int r = 2;
            foreach (var item in data)
            {
                for (int c = 0; c < props.Length; c++)
                    ws.Cell(r, c + 1).Value = props[c].GetValue(item) as string;
                r++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(path);
            Console.WriteLine($"Saved → {path}");
        }
    }

}
