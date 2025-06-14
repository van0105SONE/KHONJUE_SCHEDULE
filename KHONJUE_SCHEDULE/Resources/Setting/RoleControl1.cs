using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resource.Setting;
using KHONJUE_SCHEDULE.Resources.Setting.Controller;
using KHONJUE_SCHEDULE.Resources.Setting.model;
using KHONJUE_SCHEDULE.Utils.styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHONJUE_SCHEDULE.Resources.Setting
{
    public partial class RoleControl1 : UserControl
    {
        public static String MODULE_NAME = "ROLEPAGE";
        private DatabaseContext _databaseContext;
        private RoleController _RoleController { get; set; }
        public RoleControl1()
        {
            InitializeComponent();
            _databaseContext = new DatabaseContext();
            _databaseContext.connect();
            _RoleController = new RoleController(_databaseContext);
            loadRoleData();
            loadModuleData();
            Style.styleDatagridView(roleGridview);
            Style.styleDatagridView(moduleDatagridView);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ROLE_FORM roleForm = new ROLE_FORM();
            roleForm.ShowDialog();
            loadRoleData();
            loadModuleData();
        }

        private void loadRoleData()
        {
            List<ApplicationRole> roles = _RoleController.GetApplicationRoles();

            roleGridview.DataSource = roles;

            // Optional: Customize column headers
            roleGridview.Columns["RoleId"].HeaderText = "Role Id";
            roleGridview.Columns["RoleId"].Visible = false;
            roleGridview.Columns["RoleName"].HeaderText = "Role Name";
        }

        private void loadModuleData()
        {
            List<ApplicationModule> modules = _RoleController.GetApplicationModules();

            moduleDatagridView.DataSource = modules;
            moduleDatagridView.Columns["Id"].Visible = false;
            moduleDatagridView.Columns["ModuleName"].HeaderText = "Role Name";
            moduleDatagridView.Columns["AllowRoles"].HeaderText = "Allowed Role";

        }

        private void roleGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (roleGridview.CurrentRow != null)
            {
                string roleName = roleGridview.CurrentRow.Cells["RoleName"].Value.ToString();
                if (roleGridview.CurrentRow != null)
                {
                    ApplicationModule modules = new ApplicationModule();
                    modules.ModuleName = moduleDatagridView.CurrentRow.Cells["ModuleName"].Value.ToString();
                    modules.AllowRoles = moduleDatagridView.CurrentRow.Cells["AllowRoles"].Value.ToString();
                    _RoleController.allowdRoles(roleName, modules);
                    loadModuleData();
                }

            }
        }
    }
}
