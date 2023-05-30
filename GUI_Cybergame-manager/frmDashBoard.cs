using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
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
using System.IO;
using System.Xml.Linq;
using SuperSimpleTcp;
using System.Globalization;
using DTO_Cybergame_managers;
using Newtonsoft.Json;
using Entities;
using Untiliti;
using System.Data.Odbc;

namespace GUI_Cybergame_manager
{
    public partial class frmDashBoard : Form
    {   
        IComputerBUS cpt = new ComputerBUS();
        IEmployeeBUS emb = new EmployeeBUS();
        IOrderBUS od = new OrderBUS();
        IOrderDetailBUS odt = new OrderDetailBUS();
        
        private static int idEmployee;
        private int test = 0;
        SimpleTcpServer server;
        public static int IDemployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }
        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
            server = new SimpleTcpServer("127.0.0.1:9000");
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
            server.StartAsync();
            

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                List<string> dataList = JsonConvert.DeserializeObject<List<string>>(Encoding.UTF8.GetString(e.Data.ToArray()));
                if(dataList[0] == "Login")
                {
                    localVal.CUSID = int.Parse(dataList[2]);
                    UpdatePanelFromData(dataList);
                }
                else
                {
                    List<orderItem> orderItems = JsonConvert.DeserializeObject<List<orderItem>>(dataList[1]); // chuyển chuỗi JSON thành danh sách orderItems
                    foreach (orderItem item in orderItems)
                    {
                        renderOrderLis(item);
                    }
                }
                
                
            });
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                
            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                
            });
        }

        public frmDashBoard()
        {
            InitializeComponent();
            lbPermission.Text = emb.getEmployee_ID(localVal.EMPID).Permission;
            lbName.Location = new Point(lbPermission.Location.X + lbPermission.Width + 10, 12);
            lbName.Text = emb.getEmployee_ID(localVal.EMPID).NameEmployee;
            MemoryStream ms = new MemoryStream(emb.getEmployee_ID(localVal.EMPID).ImageEmp);
            Image image = Image.FromStream(ms);
            imgAdmin.Image = image;
            imgAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAdmin.Location = new Point(lbName.Location.X + lbName.Width + 10, 12);
        }
        //,int idCustomer,string nameCustomer,TimeSpan timeleft
        public Guna2Panel renderList(int idpc)
        {
            Guna2Panel pnComputer = new Guna2Panel();
            pnComputer.Size = new Size(192,194);
            pnComputer.FillColor = Color.FromArgb(87, 108, 188);
            pnComputer.BorderRadius = 15;
            pnComputer.Controls.Add(new Guna2Button()
            {
                Text = $"PC {idpc}",
                Size = new Size(40, 25),
                BorderRadius = 10,
                BackColor = Color.Transparent,
                Location = new Point(17, 12),
                FillColor = Color.FromArgb(165, 215, 232),
                ForeColor = Color.Black,
                Enabled = false

            }); ;
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Text = "User :",
                ForeColor = Color.Silver,
                Font = new Font("Microsoft Sans Serif",12,FontStyle.Bold),
                Location = new Point(17, 70)

            });
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Text = "Timeless :",
                ForeColor = Color.Silver,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(17, 125)

            });
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Tag = "username",
                Text = "Blank",
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(67, 70)

            });
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Tag = "timeleft",
                Text = "0",
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(101, 125)

            });
            flComputerList.Controls.Add(pnComputer);
            pnComputer.Click += PnComputer_Click;
            return pnComputer;
        }
        public void renderOrderLis(orderItem x)
        {
            Guna2GradientPanel pnItem = new Guna2GradientPanel();
            
            pnItem.Size = new Size(341, 46);
            pnItem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pnItem.BorderThickness = 1;
            pnItem.BorderColor = Color.DarkGray;
            pnItem.Margin = new Padding(11, 11, 11, 11);
            pnItem.BackColor = Color.DarkSlateBlue;
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Tag ="id",
                Text = x.id.ToString(),
                Location = new Point(3, 3),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                ForeColor = Color.White,

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Tag ="name",
                Text = x.name,
                Location = new Point(29, 15),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                ForeColor = Color.White,

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Tag = "price",
                Text = x.price.ToString(),
                Location = new Point(162, 15),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                ForeColor = Color.White,

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Tag = "quantity",
                Text = x.quantity.ToString(),
                Location = new Point(258, 15),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                ForeColor = Color.White,

            });
            flpOrderList.Controls.Add(pnItem);
        }
        private void UpdatePanelFromData(List<string> data)
        {
            
            // Tìm kiếm panel tương ứng với idpc trong dữ liệu
            Guna2Panel targetPanel = null;
            foreach (Guna2Panel panel in flComputerList.Controls)
            {
                Guna2Button button = panel.Controls.OfType<Guna2Button>().FirstOrDefault();
                if (button != null && button.Text == $"PC {data[1]}")
                {
                    targetPanel = panel;
                    break;
                }
            }

            // Nếu tìm thấy panel tương ứng
            if (targetPanel != null)
            {
                // Cập nhật các giá trị trong panel
                Guna2HtmlLabel userLabel = targetPanel.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(l => l.Tag == "username");
                if (userLabel != null)
                {
                    userLabel.Text = data[3];
                }

                Guna2HtmlLabel timeLabel = targetPanel.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(l => l.Tag == "timeleft");
                if (timeLabel != null)
                {
                    timeLabel.Text = data[4];
                }
            }
        }

        private void PnComputer_Click(object sender, EventArgs e)
        {
            
        }

        public void LoadData()
        {

            foreach (Computer c in cpt.getAll())
            {

                flComputerList.Controls.Add(renderList(c.IDComputer));
                
            }
        }
        public void KetXuatWord()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Word | *.docx";
            saveFileDialog.Title = "Lưu thông hóa đơn";
            string filePath = "C:\\hoadon\\" + localVal.EMPID + "-" + ".docx";
            FileInfo fi = new FileInfo(filePath);
            fi.Create().Close();
            if (fi.FullName != "")
            {
                try
                {
                    odt.KetXuatWord(localVal.EMPID, localVal.CUSID, @"Template\hoadon.docx", fi.FullName);
                    MessageBox.Show("Kết xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo lỗi01");
                }
            }

        }
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                
                    int val = od.Insert(DateTime.Now, localVal.EMPID, localVal.CUSID, 0);
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
            int idOrder = od.GetOrder().IDOrder;
            foreach (Guna2GradientPanel panel in flpOrderList.Controls.OfType<Guna2GradientPanel>())
            {
                string idItem = panel.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Tag == "id")?.Text;
                string quantity = panel.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Tag == "quantity")?.Text;
                string name = panel.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Tag == "nameItem")?.Text;
                string price = panel.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Tag == "price")?.Text;

                MessageBox.Show($"{idItem}", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"{price}", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"{quantity}", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try
                {

                    int val = odt.Insert(idOrder, int.Parse(idItem), decimal.Parse(price), int.Parse(quantity));
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
                

            }
            KetXuatWord();
        }
    }
}
