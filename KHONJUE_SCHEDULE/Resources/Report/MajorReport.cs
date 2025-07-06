using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Report.Controller;
using KHONJUE_SCHEDULE.Resources.Schedule.controller;
using KHONJUE_SCHEDULE.Utils;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KHONJUE_SCHEDULE.Resources.Report
{
    public partial class MajorReport : UserControl
    {
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private SubjectController _subjController { get; set; }
        private ScheduleController _scheduleController { get; set; }
        private TimePeriodController _timePeriodController { get; set; }
        private MajorController _majorController { get; set; }
        private TermController _termController { get; set; }
        private StudentClassController _studentClassController { get; set; }
        public MajorReport()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _termController = new TermController(_dbContext);
            _levelController = new LevelController(_dbContext);
            _subjController = new SubjectController(_dbContext);
            _scheduleController = new ScheduleController(_dbContext);
            _timePeriodController = new TimePeriodController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _studentClassController = new StudentClassController(_dbContext);
            this.generateReport();
        }

        async private void button8_Click(object sender, EventArgs e)
        {
            this.generateReport();
        }

        async private void generateReport()
        {
            this.REPORT_CONTAINER.Controls.Clear();
            var data = _majorController.getMajors("");
            var report = new MajorReportController(data);
            string path = Path.Combine(Environment.CurrentDirectory, "ScheduleReport.pdf");
            report.GeneratePdf(path);

            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.SuspendLayout();

            this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(2500, 450);

            this.REPORT_CONTAINER.Controls.Add(this.webView2);
            this.ResumeLayout(false);

            if (File.Exists(path))
            {
                await webView2.EnsureCoreWebView2Async();

                // Navigate away briefly to force reload
                webView2.CoreWebView2.Navigate("about:blank");

                // Then navigate to the updated PDF file
                webView2.CoreWebView2.Navigate($"file:///{path.Replace("\\", "/")}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, @$"MAJOR-{DateTime.Now.ToString("MMDDYYYY")}.pdf");
            var data = _majorController.getMajors("");
            var report = new MajorReportController(data);
            report.GeneratePdf(filePath);

            Console.WriteLine($"PDF saved to: {filePath}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var data = _majorController.getMajors("");
            ExcelExport.ToExcelClosedXml(data, @$"MAJOR-{DateTime.Now.ToString("MMDDYYYY")}.xlsx");
        }
    }
}
