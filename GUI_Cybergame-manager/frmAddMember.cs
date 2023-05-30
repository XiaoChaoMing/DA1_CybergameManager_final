using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
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
    public partial class frmAddMember : Form
    {
        ICustomer mb = new CustomerBUS();
        IHistoryFillBUS hf = new HistoryFillBUS();
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            frmCustommer frmCustomer = Application.OpenForms.OfType<frmCustommer>().FirstOrDefault();
            if (txtMemberID.Text == "" || txtMemberName.Text == "" || txtMemberAcc.Text == "" || txtMemberPass.Text =="" || txtMemberMoney.Text == "")
                MessageBox.Show("Dữ liệu chưa đủ, vui lòng nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    
                    int val = mb.Insert(new Customer(Convert.ToInt32(txtMemberID.Text),txtMemberName.Text,txtMemberAcc.Text,txtMemberPass.Text,Convert.ToDecimal(txtMemberMoney.Text),Tool.QuyDoiGia(Convert.ToDecimal(txtMemberMoney.Text))));
                    
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // fill money data history
                try
                {
                    int val = hf.Insert(new HistoryFill(localVal.EMPID, Convert.ToInt32(txtMemberID.Text), DateTime.Now, Convert.ToDecimal(txtMemberMoney.Text)));

                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (frmCustomer != null)
                        {
                            // Gọi sự kiện Load của frmCustomer
                            frmCustomer.frmCustommer_Load(sender, e);
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
