using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using Newtonsoft.Json;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Cybergame_users
{
    public partial class frmLoginUser : Form
    {
        public SimpleTcpClient client;
        ICustomer mb = new CustomerBUS();
        public static frmLoginUser _instance;
        public frmLoginUser()
        {
            InitializeComponent();
            _instance = this;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                try
                {
                    SqlDataReader rdr = mb.checkAcount_ID(txtAccount.Text, txtPassword.Text);
                    if (rdr.Read())
                    {
                        MessageBox.Show("Đăng nhập thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLockScreen.HideLockSC();
                        this.Hide();
                        try
                        {
                            localVal.CUSID = mb.getCusTomer_ID(txtAccount.Text, txtPassword.Text).IDCustomer;
                            int val = mb.UpdateStatus(localVal.CUSID, true);
                            localVal.CUSSTATE = mb.getCusTomer_ID(txtAccount.Text, txtPassword.Text).Status;
                            localVal.Customer = mb.getCusTomer_ID(txtAccount.Text, txtPassword.Text);
                            // show maint form
                            frmMaintUser f = new frmMaintUser();
                            f.Show();
                            // send data to sever
                            List<string> mess = new List<string>();
                            mess.Add("Login");
                            mess.Add("1");
                            mess.Add(localVal.CUSID.ToString());
                            mess.Add(localVal.Customer.NameCustomer);
                            mess.Add(localVal.Customer.TimeLeftCus.ToString());
                            string dataSend = JsonConvert.SerializeObject(mess);
                            client.Send(dataSend);
                            if (val == -1)
                                MessageBox.Show("Tài khoản không tồn tại, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch
                        {
                            MessageBox.Show("Số dư tài khoản không đủ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmLoginUser_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1:9000");
            client.Events.DataReceived += Events_DataReceived;
            client.Connect();
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
