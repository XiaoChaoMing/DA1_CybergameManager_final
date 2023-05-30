using BUS_Cybergame_managers.Interface;
using BUS_Cybergame_managers;
using DTO_Cybergame_managers;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Untiliti;
using Entities;
using System.Linq.Expressions;
using System.Drawing.Drawing2D;

namespace GUI_Cybergame_manager
{
    public partial class frmCategory : Form
    {
        ICategoryBUS ct = new CategoryBUS();
        ISupplierBUS supp = new SupplierBUS();
        IImpornOrderBUS impo = new ImportOrderBUS();
        IImportdetailBUS dt = new ImportdetailBUS();
        private Guna2PictureBox currenpic;
        private decimal t;
        public frmCategory()
        {
            InitializeComponent();
        }
        private void clickImage(object senderPicItem)
        {
            currenpic = (Guna2PictureBox)senderPicItem;
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                currenpic.Image = Image.FromFile(openDlg.FileName);
                currenpic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            currenpic.Refresh();
        }
        private void imgItem_Click_1(object sender, EventArgs e)
        {
            clickImage(sender);
        }
        public void LoadData()
        {
            dgvSupliers.DataSource = supp.getAll();
            dgvListItem.DataSource = ct.getAll();
            dgvFoodItem.Rows.Clear();
            foreach (Categorys e in ct.getAll())
            {
                int rowIndex = dgvFoodItem.Rows.Add(); // thêm một dòng mới và lấy chỉ số của dòng đó
                dgvFoodItem.Rows[rowIndex].Height = 75;
                DataGridViewRow row = dgvFoodItem.Rows[rowIndex];
                row.Cells["idItem"].Value = e.IDitem;
                row.Cells["nameItem"].Value = e.NameItem;
                row.Cells["idClassItem"].Value = e.IDClassItem;
                row.Cells["quantityItem"].Value = e.QuantityItem;
                row.Cells["dramItem"].Value = e.DramItem;
                row.Cells["priceItem"].Value = e.PriceItem;
                row.Cells["imageItem"].Value = e.ImageItem;
                
                
            }

        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = Application.OpenForms.OfType<frmEmployee>().FirstOrDefault();
            //if (txtIdItem.Text == "" || txtNameItem.Text == "" || txt.Text == "" || txtBirthDay.Text == "" || txtPhoneNumber.Text == "")
            //{
            //    MessageBox.Show("Dữ liệu chưa đủ, vui lòng nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            
                try
                {

                    MemoryStream stream = new MemoryStream();
                    if (imgItem.Image != null)
                    {
                        // Lưu trữ hình ảnh vào MemoryStream
                        imgItem.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        // Chuyển đổi nội dung của MemoryStream thành một mảng byte
                        byte[] imageBytes = stream.ToArray();
                        int val = ct.Insert(new Categorys(Convert.ToInt32(txtIdItem.Text), txtNameItem.Text, Tool.PhanLoai(cbbIDClassItem.Text), 0, txtDramItem.Text, Convert.ToDecimal(txtPrice.Text), imageBytes));
                        if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ảnh không được để trống!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
            tabControl1.TabPages[1].Enabled = false;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                int val = ct.Delete(int.Parse(dgvFoodItem[0, dgvFoodItem.CurrentCell.RowIndex].Value.ToString()));
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

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            try
            {
                int val = supp.Insert(new supplier(Convert.ToInt32(txtidSupp.Text), txtSuppName.Text));
                if (val == -1)
                    MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnFillticket_Click(object sender, EventArgs e)
        {
            ImportOrder imp = new ImportOrder();
            imp.TimeCre = DateTime.Now;
            imp.IDEmployee = localVal.EMPID;
            imp.IDSupp = int.Parse(dgvSupliers[0, dgvSupliers.CurrentCell.RowIndex].Value.ToString());
            imp.Money = 0;
            try
            {
                int val = impo.Insert(imp);
                if (val == -1)
                    MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    tabControl1.SelectTab(1);
                    tabControl1.TabPages[1].Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvListItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemID.Text = dgvListItem[0, dgvListItem.CurrentCell.RowIndex].Value.ToString();
            txtItemName.Text = dgvListItem[1, dgvListItem.CurrentCell.RowIndex].Value.ToString();
            
        }

        private void btnitemAdd_Click(object sender, EventArgs e)
        {
            
            
            try
            {

                int rowIndex = dgvListImport.Rows.Add();
                DataGridViewRow row = dgvListImport.Rows[rowIndex];
                row.Cells["cl_idItem"].Value = txtItemID.Text;
                row.Cells["cl_nameItem"].Value = txtItemName.Text;
                decimal quantity, price;
                if (decimal.TryParse(txtQuantity.Text, out quantity) && decimal.TryParse(txtPriceItem.Text, out price))
                {
                    row.Cells["cl_quantity"].Value = quantity;
                    row.Cells["cl_price"].Value = price;
                    t += quantity * price;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số vào ô Số lượng và Giá", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvListImport.Rows.RemoveAt(rowIndex);
                }   
            }
            catch
            {
                
                MessageBox.Show("Thông tin không hợp lệ,vui lòng nhập lại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            lbTotalMoney.Text = t.ToString();
        }
        public void KetXuatWord(int ncc)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông tin lớp";
            DateTime today = DateTime.Now;
            string filePath = "C:\\hoadon\\"+ localVal.EMPID + "-" + today.Day + "-" + today.Hour + "-" + today.Minute + "-" + today.Second + ".docx";
            FileInfo fi = new FileInfo(filePath);
            fi.Create().Close();
            if (fi.FullName != "")
            {
                try
                {
                    dt.KetXuatWord(localVal.EMPID, ncc, @"Template\hoadonnhap.docx", fi.FullName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi01");
                }
            }

        }
        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            int ncc = int.Parse(dgvSupliers[0, dgvSupliers.CurrentCell.RowIndex].Value.ToString());
            foreach (DataGridViewRow row in dgvListImport.Rows)
            {
                ImportDetail x = new ImportDetail();
                x.IDImportOrder = impo.GetImport().IDImportOrder;
                x.IDItem = int.Parse(row.Cells[0].Value.ToString());
                x.PriceItem = decimal.Parse(row.Cells[2].Value.ToString());
                x.QuantityItem = int.Parse(row.Cells[3].Value.ToString());
                try
                {
                    int val = dt.Insert(x);
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            // update quantity menu
            foreach (DataGridViewRow row in dgvListImport.Rows)
            {
                Categorys x = new Categorys();
                x.IDitem = int.Parse(row.Cells[0].Value.ToString());
                x.QuantityItem =int.Parse(row.Cells[2].Value.ToString());
                try
                {
                    int val = ct.UpdateQuantity(x);
                    if (val == -1)
                    {
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        LoadData();
                    }
                        
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            // update total money DHN
            try
            {
                int val = impo.Update(decimal.Parse(lbTotalMoney.Text));

                if (val == -1)
                    MessageBox.Show("Lưu đơn hàng không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Lưu đơn hàng nhập thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.TabPages[1].Enabled = false;
                    dgvListImport.Rows.Clear();
                    txtItemID.Text = "";
                    txtItemName.Text = "";
                    txtQuantity.Text = "";
                    txtPriceItem.Text = "";
                    lbTotalMoney.Text = "";
                    t = 0;

                }
            }
            catch
            {
                MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            KetXuatWord(ncc);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnameSearch.Text))
            {
                MessageBox.Show("Thông tin không hợp lệ,vui lòng nhập lại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (cbbClassItem.Text)
            {
                default:
                    Categorys c = new Categorys();
                    c.NameItem = txtnameSearch.Text;
                    dgvListItem.DataSource = ct.SearchLinq(c);
                    break;
                case "Đồ ăn":
                    Categorys m = new Categorys();
                    m.NameItem = txtnameSearch.Text;
                    m.IDClassItem = 1;
                    dgvListItem.DataSource = ct.SearchLinq(m);
                    break;
                case "Đồ uống":
                    Categorys n = new Categorys();
                    n.NameItem = txtnameSearch.Text;
                    n.IDClassItem = 2;
                    dgvListItem.DataSource = ct.SearchLinq(n);
                    break;
                case "Thẻ nạp":
                    Categorys p = new Categorys();
                    p.NameItem = txtnameSearch.Text;
                    p.IDClassItem = 3;
                    dgvListItem.DataSource = ct.SearchLinq(p);
                    break;
                case "Đồ ăn vặt":
                    Categorys t = new Categorys();
                    t.NameItem = txtnameSearch.Text;
                    t.IDClassItem = 4;
                    dgvListItem.DataSource = ct.SearchLinq(t);
                    break;
            }
            

            

        }
    }
}
