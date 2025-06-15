using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHONJUE_SCHEDULE.Resources.Schedule;

namespace KHONJUE_SCHEDULE.Resources.Search
{
    public partial class SearchPage : UserControl
    {
        public SearchPage()
        {
            InitializeComponent();
            MAIN_CONTAINER.Controls.Clear();
            SearchContainer inforPage = new SearchContainer();
            inforPage.Dock = DockStyle.Fill;
            this.MAIN_CONTAINER.Controls.Add(inforPage);
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {

        }
    }
}
