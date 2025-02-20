using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Utils.styles
{
    public  class Style
    {

        public  static void styleDatagridView(DataGridView gridView)
        {
            // Set DataGrid appearance to be more beautiful
           gridView.BorderStyle = BorderStyle.None; // Remove borders
           gridView.BackgroundColor = Color.White; // Set background to white
           gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Light gray on alternating rows
           gridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black; // Black text on alternating rows
           gridView.DefaultCellStyle.BackColor = Color.White; // White background for rows
           gridView.DefaultCellStyle.ForeColor = Color.Black; // Black text for rows

         //  gridViewcolor change when selecting a cell
           gridView.DefaultCellStyle.SelectionBackColor = Color.White; // No background color when selected
           gridView.DefaultCellStyle.SelectionForeColor = Color.Black; // Keep text color black when selected

           gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto fit columns
           gridView.RowTemplate.Height = 35; // Set row height for a cleaner look


           gridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(220, Color.White); // Add slight opacity to row backgrounds

           gridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
           gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

           gridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False; // Disable text wrapping
           gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Align text to the left
           gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Noto Sans Lao", 14, FontStyle.Bold); // Larger font size for header
           gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Set header text color to black
           gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; // Light gray for headers
           gridView.EnableHeadersVisualStyles = false; // Disable the default header style to use custom style
           gridView.DefaultCellStyle.Font = new Font("Noto Sans Lao", 11, FontStyle.Regular); // Increase text size for data rows
           gridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False; // Disable text wrapping
           gridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Align text to the left
        }
    }
}
