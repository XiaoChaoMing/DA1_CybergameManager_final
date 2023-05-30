using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using DTO_Cybergame_managers;
using Entities;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Untiliti;
using Entities;
using System.IO;

namespace GUI_Cybergame_manager
{
    public partial class frmAddEmployee : Form
    {
        private byte[] ImgEmployeeAva;
        private string CbbPermission;
        private string TxtEmployeeID;
        private string TxtEmployeeName;
        private string TxtEmployeePass;
        private string CbbSexual;
        private string TxtBirthDay;
        private string TxtPhoneNumber;

        public byte[] IMGEMPLOYEEAVA
        {
            get { return ImgEmployeeAva; }
            set { ImgEmployeeAva = value; }
        }
        
        Guna2PictureBox currentpic;
        IEmployeeBUS emb = new EmployeeBUS();
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            frmEmployee frm = Application.OpenForms.OfType<frmEmployee>().FirstOrDefault();
            if (txtEmployeeID.Text == "" || txtEmployeeName.Text == "" || txtEmployeePass.Text == "" || txtBirthDay.Text == "" || txtPhoneNumber.Text == ""||imgEmployeeAva!=null)
            {
                MessageBox.Show("Dữ liệu chưa đủ, vui lòng nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MemoryStream stream = new MemoryStream();
                    // Lưu trữ hình ảnh vào MemoryStream
                    
                        imgEmployeeAva.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        // Chuyển đổi nội dung của MemoryStream thành một mảng byte
                        byte[] imageBytes = stream.ToArray();
                        int val = emb.Insert(new Employee(Convert.ToInt32(txtEmployeeID.Text), txtEmployeeName.Text, txtEmployeePass.Text, txtPhoneNumber.Text, cbbSexual.Text == "Nam" ? true : false, Convert.ToDateTime(txtBirthDay.Text), imageBytes, cbbPermission.Text));
                        //int val = emb.Insert(new Employee(1, "minh", "1", "012345", true, DateTime.Now, imageBytes, "Quan ly"));
                        if (val == -1)
                            MessageBox.Show("Thêm nhân viên thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            MessageBox.Show("Đã thêm nhân viên thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (frm != null)
                            {
                                // Gọi sự kiện Load của frmCustomer

                                frm.frmEmployee_Load(sender, e);
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

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            //MemoryStream ms = new MemoryStream(ImgEmployeeAva);

            //// chuyển đổi từ mảng byte[] thành đối tượng Image
            //Image image = Image.FromStream(ms);
            //imgEmployeeAva.Image = image;
            //imgEmployeeAva.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
