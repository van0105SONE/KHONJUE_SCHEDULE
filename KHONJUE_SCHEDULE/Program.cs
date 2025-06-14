using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Setting.Controller;
using QuestPDF.Infrastructure;

namespace KHONJUE_SCHEDULE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DatabaseContext context = new DatabaseContext();
            context.connect();
            RoleController role = new RoleController(context);
            role.createApplicationModule();
            Application.Run(new Form1());
        }
    }
}