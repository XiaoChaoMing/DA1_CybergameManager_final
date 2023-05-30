using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_Cybergame_manager
{
    public partial class frmChart : Form
    {
        IchartBUS blltke = new chartBUS();
        public frmChart()
        {
            InitializeComponent();
            
        }
        public void Dothi()
        {
            //int[] data = { 10, 20, 30, 40, 50 };

            // Đổ dữ liệu từ mảng vào chuỗi
            for (int i = 0; i < blltke.Tongdaonhthutheothang().Count; i++)
            {
                dynamic item = blltke.Tongdaonhthutheothang()[i];
                chart1.Series["Doanh thu"].Points.AddXY(i + 1, item.GetType().GetProperty("TotalAmount").GetValue(item, null));
            }

            // Đặt loại biểu đồ là Column
            chart1.Series["Doanh thu"].ChartType = SeriesChartType.Column;
        }
        private void frmChart_Load(object sender, EventArgs e)
        {
            Dothi();
        }
    }
}
