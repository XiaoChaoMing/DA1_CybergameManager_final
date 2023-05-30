using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Untiliti;

namespace GUI_Cybergame_users
{
    public partial class frmMaintUser : Form
    {
        ICustomer mb = new CustomerBUS();
        private static frmMaintUser _instance;
        private TimeSpan remainingTime;
        private TimeSpan beforPlay;
        public frmMaintUser()
        {
            InitializeComponent();
            _instance = this;
        }
        public static void CloseF()
        {
            _instance.Close();
        }
        private void frmMaintUser_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            loaddata();

        }
        public void loaddata()
        {
            lbNameCus.Text = localVal.Customer.NameCustomer;
            txtTotalTime.Text = localVal.Customer.TimeLeftCus.ToString();
            TimeSpan timeLeft = localVal.Customer.TimeLeftCus;
            beforPlay = localVal.Customer.TimeLeftCus;
            StartCountdown(timeLeft);
        }

        private void imgMessage_Click(object sender, EventArgs e)
        {
            frmMessage frm = new frmMessage();
            frm.Show();
        }

        private void imgMenuOrder_Click(object sender, EventArgs e)
        {
            frmMenuOrder frm = new frmMenuOrder();
            frm.Show();
        }

        public void imgLogOut_Click(object sender, EventArgs e) 
        {
            CloseF();
            //List<string> mess = new List<string>();
            //mess.Add("Logout");
            //mess.Add("1");
            //mess.Add(localVal.CUSID.ToString());
            //mess.Add(localVal.Customer.NameCustomer);
            //mess.Add(localVal.Customer.TimeLeftCus.ToString());
            //string dataSend = JsonConvert.SerializeObject(mess);
            //client.Send(dataSend);
            //frmLoginUser._instance.client.Send();
            mb.Updatetime(localVal.CUSID, Tool.QuyDoithoiGian(remainingTime),remainingTime,(beforPlay-remainingTime),false);
            frmLockScreen.ShowLockSC();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTotalTime.Text = localVal.Customer.TimeLeftCus.ToString();

            // Kiểm tra nếu thời gian còn lại bằng 0
            if (remainingTime <= TimeSpan.Zero)
            {
                txtTimeLeft.Text = "00:00:00";
                MessageBox.Show("Hết giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.imgLogOut_Click(sender, e);
                return;
            }

            remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1)); // Giảm giá trị của biến remainingTime đi 1 giây
            txtTimeLeft.Text = remainingTime.ToString(@"hh\:mm\:ss"); // Hiển thị giá trị mới vào textbox
        }
        private void StartCountdown(TimeSpan duration)
        {
            remainingTime = duration; // Khởi tạo giá trị remainingTime bằng độ dài thời gian cần đếm ngược
            txtTimeLeft.Text = remainingTime.ToString(@"hh\:mm\:ss"); // Hiển thị giá trị ban đầu vào textbox
            timer1.Start(); // Bắt đầu đếm ngược
        }
    }
}
