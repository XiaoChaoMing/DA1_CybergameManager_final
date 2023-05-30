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
using Entities;
using Untiliti;
using DTO_Cybergame_managers;

namespace GUI_Cybergame_manager
{
    public partial class frmAddComputer : Form
    {
        IComputerBUS cpt = new ComputerBUS();

        public frmAddComputer()
        {
            InitializeComponent(); 
        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            frmComputer frm= Application.OpenForms.OfType<frmComputer>().FirstOrDefault();
            if (txtComputerID.Text == "" || txtNameComputer.Text == "" || txtConfig.Text == "" || txtStatus.Text == "" || cbbRoomID.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, vui lòng nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {

                    int val = cpt.Insert(new Computer(Convert.ToInt32(txtComputerID.Text), Convert.ToInt32(cbbRoomID.Text), txtNameComputer.Text, txtStatus.Text, txtConfig.Text ));

                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (frm != null)
                        {
                            // Gọi sự kiện Load của frmCustomer
                            frm.frmComputer_Load(sender,e);
                            this.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
