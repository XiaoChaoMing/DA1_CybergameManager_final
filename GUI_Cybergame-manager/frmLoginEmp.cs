using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Cybergame_manager
{
    public partial class frmLoginEmp : Form
    {
        IAccountBUS acc = new AccountBUS();
        IEmployeeBUS emb = new EmployeeBUS();
        
        public frmLoginEmp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccountEmp.Text != string.Empty || txtPassEmp.Text != string.Empty || cbbPermission.Text != string.Empty)
            {
                try
                {
                    
                    localVal.EMPID = int.Parse(txtAccountEmp.Text);
                    SqlDataReader rdr = acc.checkItem_ID(int.Parse(txtAccountEmp.Text), txtPassEmp.Text,cbbPermission.Text);
                    if (rdr.Read())
                    {
                        MessageBox.Show("Đăng nhập thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMaint f = new frmMaint();
                        
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại, kiểm tra lại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Thông tin không chính xác", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ các trường", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassEmp.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassEmp.UseSystemPasswordChar = true;
            }


        }
    }
}
