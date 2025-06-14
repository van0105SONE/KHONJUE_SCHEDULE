using KHONJUE_SCHEDULE.Resources.Schedule.Model;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Utils
{
    class ReportUtil
    {
        public static void Load(LocalReport report, List<ScheduleModel> data)
        {
            //var parameters = new[] { new ReportParameter("Title", "Invoice 4/2020") };
            //using var fs = new FileStream("Report.rdlc", FileMode.Open);
            //report.LoadReportDefinition(fs);
            //report.DataSources.Add(new ReportDataSource("DataSet1", data));
            //report.SetParameters(parameters);
        }
    }
}
