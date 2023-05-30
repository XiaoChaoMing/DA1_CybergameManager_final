using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using DTO_Cybergame_managers;
using Entities;

namespace GUI_Cybergame_manager
{
    public partial class frmEmployee : Form
    {
        IEmployeeBUS emb = new EmployeeBUS();
        public frmEmployee()
        {
            InitializeComponent();
            
            
        }
        public void LoadData()
        {
            dgvEmployee.Rows.Clear();
            foreach (Employee e in emb.getAll())
            {
                int rowIndex = dgvEmployee.Rows.Add(); // thêm một dòng mới và lấy chỉ số của dòng đó
                DataGridViewRow row = dgvEmployee.Rows[rowIndex];
                dgvEmployee.Rows[rowIndex].Height = 75;
                row.Cells["idEmployee"].Value = e.IDEmployee; 
                row.Cells["nameEmployee"].Value = e.NameEmployee; 
                row.Cells["passEmp"].Value =e.PassEmp; 
                row.Cells["phoneNumber"].Value = e.PhoneNumber;
                row.Cells["sexualEmp"].Value = e.SexualEmp == true?"Nam":"Nữ";
                row.Cells["birthEmp"].Value = e.BirthEmp;
                row.Cells["imageEmp"].Value = e.ImageEmp;
                row.Cells["permission"].Value = e.Permission;
            }

        }
        
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee f = new frmAddEmployee();
            f.Show();
        }

        public void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            frmAddEmployee f = new frmAddEmployee();
            f.IMGEMPLOYEEAVA = (byte[])dgvEmployee[7, dgvEmployee.CurrentCell.RowIndex].Value;
            f.Show();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                int val = emb.Delete(int.Parse(dgvEmployee[0, dgvEmployee.CurrentCell.RowIndex].Value.ToString()));
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
