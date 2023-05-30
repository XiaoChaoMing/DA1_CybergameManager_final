using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using DTO_Cybergame_managers;
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
    public partial class frmComputer : Form
    {
        IComputerBUS cpt = new ComputerBUS();
        public frmComputer()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvComputer.DataSource = cpt.getAll();

        }


        public void frmComputer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddComputer_Click_1(object sender, EventArgs e)
        {
            frmAddComputer f = new frmAddComputer();
            f.Show();
        }

        private void btnDeleteComputer_Click(object sender, EventArgs e)
        {
            try
            {
                int val = cpt.Delete(int.Parse(dgvComputer[0, dgvComputer.CurrentCell.RowIndex].Value.ToString()));
                LoadData();
                if (val == -1)
                    MessageBox.Show("Xóa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
