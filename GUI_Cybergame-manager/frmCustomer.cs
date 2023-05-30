using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using Microsoft.VisualBasic;
using Untiliti;
using Entities;
namespace GUI_Cybergame_manager
{
    
    public partial class frmCustommer : Form
    {
        
        ICustomer mb = new CustomerBUS();
        public frmCustommer()
        {
            InitializeComponent();
            dgvCustommers.CellFormatting += dgvCustommers_CellFormatting;

        }
        public void LoadData()
        {
            dgvCustommers.DataSource = mb.getAll();
            dgvCustommers.Columns["IDCustomer"].HeaderText = "ID Thành Viên";
            dgvCustommers.Columns["NameCustomer"].HeaderText = "Tên Thành Viên";
            dgvCustommers.Columns["AccountCus"].HeaderText = "Tên Tài Khoản";
            dgvCustommers.Columns["PasswordCus"].HeaderText = "Mật Khẩu";
            dgvCustommers.Columns["MoneyCus"].HeaderText = "Số Dư";
            dgvCustommers.Columns["TimeLeftCus"].HeaderText = "Thời Gian Còn Lại";
            dgvCustommers.Columns["TotalTime"].HeaderText = "Tổng Thời Gian Chơi";
            
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.Show();
        }
        private void btnHistoryView_Click(object sender, EventArgs e)
        {
            frmHistoryFill frmHistoryFill = new frmHistoryFill();
            frmHistoryFill.Show();
        }

        private void btnHistoryPlay_Click(object sender, EventArgs e)
        {
            frmHistoryPlay frmHistoryPlay = new frmHistoryPlay();
            frmHistoryPlay.Show();
        }

        public void frmCustommer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCustommers_DoubleClick(object sender, EventArgs e)
        {
            frmFillMoney f = new frmFillMoney();
            f.TXTIDCUSTOMER = dgvCustommers[0, dgvCustommers.CurrentCell.RowIndex].Value.ToString();
            f.TXTCUSTOMERACC = dgvCustommers[1, dgvCustommers.CurrentCell.RowIndex].Value.ToString();
            f.TXTMONEYREMAINT = dgvCustommers[4, dgvCustommers.CurrentCell.RowIndex].Value.ToString();
            f.TXTTIMELEFT = dgvCustommers[5, dgvCustommers.CurrentCell.RowIndex].Value.ToString();
            f.Show();

        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                int val = mb.Delete(int.Parse(dgvCustommers[0, dgvCustommers.CurrentCell.RowIndex].Value.ToString()));
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

        private void dgvCustommers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCustommers.Columns[e.ColumnIndex].Name == "PasswordCus")
            {
                if (e.Value != null)
                {
                    string password = new string('*', e.Value.ToString().Length);
                    e.Value = password;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            Customer m = new Customer();
            m.NameCustomer = txtMemberSearch.Text;
            dgvCustommers.DataSource = mb.SearchLinq(m);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
