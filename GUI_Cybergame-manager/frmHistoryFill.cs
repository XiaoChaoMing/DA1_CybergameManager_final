using BUS_Cybergame_managers.Interface;
using BUS_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Cybergame_manager
{
    public partial class frmHistoryFill : Form
    {
        IHistoryFillBUS hf = new HistoryFillBUS();
        public frmHistoryFill()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvFillHistory.DataSource = hf.getAll();
           

        }
        private void frmHistoryFill_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
