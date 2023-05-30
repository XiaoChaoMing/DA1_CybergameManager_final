using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using DTO_Cybergame_managers;
using Guna.UI2.WinForms;
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

namespace GUI_Cybergame_manager
{
    public partial class frmShowEmployee : Form
    {
         IEmployeeBUS emb = new EmployeeBUS();
        Guna2PictureBox currentpic;
        public frmShowEmployee()
        {
            InitializeComponent();
        }

        private void frmShowEmployee_Load(object sender, EventArgs e)
        {
            Employee em = emb.getEmployee_ID(localVal.EMPID);
            
            txtEmployeeID.Text = em.IDEmployee.ToString();
            txtEmployeeName.Text = em.NameEmployee.ToString();
            txtEmployeePass.Text = em.PassEmp.ToString();
            txtBirthDay.Text = em.BirthEmp.ToString();
            txtPhoneNumber.Text = em.PhoneNumber.ToString();
            cbbSexual.Text = em.SexualEmp == true?"Nam":"Nữ";
            cbbPermission.Text = em.Permission.ToString();
            MemoryStream ms = new MemoryStream(em.ImageEmp.ToArray());
            imgEmployeeAva.Image = Image.FromStream(ms);
            imgEmployeeAva.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            // Lưu trữ hình ảnh vào MemoryStream

            imgEmployeeAva.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Chuyển đổi nội dung của MemoryStream thành một mảng byte
            byte[] imageBytes = stream.ToArray();
            try
            {
                int val = emb.Update(new Employee(Convert.ToInt32(txtEmployeeID.Text), txtEmployeeName.Text, txtEmployeePass.Text, txtPhoneNumber.Text, cbbSexual.Text == "Nam" ? true : false, Convert.ToDateTime(txtBirthDay.Text), imageBytes, emb.getEmployee_ID(localVal.EMPID).Permission));

                if (val == -1)
                    MessageBox.Show("Sửa thông tin không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Sửa thông tin thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMaint.CloseF();
                    frmLoginEmp f = new frmLoginEmp();
                    f.Show();
                }
            }
            catch
            {
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void clickImage(object senderPicItem)
        {
            currentpic = (Guna2PictureBox)senderPicItem;
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                currentpic.Image = Image.FromFile(openDlg.FileName);
                currentpic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            currentpic.Refresh();
        }
        private void imgEmployeeAva_Click(object sender, EventArgs e)
        {
            clickImage(sender);

        }
    }
}
