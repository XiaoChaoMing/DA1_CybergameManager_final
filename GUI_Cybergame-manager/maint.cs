using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Cybergame_managers;
using Guna.UI2.WinForms;
using SuperSimpleTcp;

namespace GUI_Cybergame_manager
{
    public partial class frmMaint : Form
    {
        
        private Guna2DragControl dragControl;
        private Guna2Button currenBtn ;
        private Guna2Button currentClickBtn;
        
        // side bar icons default
        private string[] iconPaths = new string[8] {
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\house.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\customer.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\employee.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\computers.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\foodmenu.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\chart.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\setting.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\activelogo\\signout.png",

        };
        // side bar icons active
        private string[] activeIconPath = new string[8] {
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\3844435_home_house_icon.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\1564534_customer_man_user_account_profile_icon.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\4850470_card_employee_id_identification_identity_icon.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\2205198_destop_computer_it_icon.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\6811936_breakfast_cutlery_eating_food_lunch_icon.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\1564531_chart_business_graph_statistics_icon.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\1564529_mechanism_options_settings_configuration_setting_icon.png",
            "C:\\Users\\Acer\\source\\repos\\DA1_CybergameManager\\GUI_Cybergame-manager\\Resources\\imgSrc\\signouticon.png",
        };
        // tab name 
        private string[] tabName = new string[8]
        {
            "Home",
            "Customer",
            "Employee",
            "Computer",
            "Food menu",
            "Chart",
            "Setting",
            "Logout"
        };
        private static frmMaint _instance;
        public frmMaint()
        {
            InitializeComponent();
            dragControl = new Guna2DragControl();
            dragControl.TargetControl = this;
            _instance = this;
        }
        public void Test()
        {
            lbTabName.Text = "dell";
        }
        public static void CloseF()
        {
            _instance.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        // hover event
        private void MouseEnterBtn(object senderBtn)
        {
            if(senderBtn != null)
            {
                currenBtn = (Guna2Button)senderBtn;
                currenBtn.ImageSize = new Size(35,35);


            }
        }
        private void MouseLeaveBtn(object senderBtn)
        {
            if (senderBtn != null)
            {
                currenBtn = (Guna2Button)senderBtn;
                currenBtn.ImageSize = new Size(30, 30);

            }
        }
        //click event
        private void ActiveBtn(object senderBtn)
        {
            DisableBtn();
            if (senderBtn != null)
            {
                
                currentClickBtn = (Guna2Button)senderBtn;
                currentClickBtn.Image = Image.FromFile(iconPaths[currentClickBtn.TabIndex]);
                currentClickBtn.FillColor = Color.FromArgb(25, 55, 109);
                currentClickBtn.BorderRadius = 5;
                ChangeTabName();
            }
        }
        private void DisableBtn()
        {
            if (currentClickBtn != null)
            {

                currentClickBtn.Image = Image.FromFile(activeIconPath[currentClickBtn.TabIndex]);
                currentClickBtn.FillColor = Color.Transparent;
                currentClickBtn.BorderRadius = 0;

            }
        }
        private void ChangeTabName()
        {
            lbTabName.Text = tabName[currentClickBtn.TabIndex];
        }
        // Drag Form
        [DllImport("user32.DLL",EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam, int lParam);

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnEmployee_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnComputers_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnComputers_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnFoodMenu_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnFoodMenu_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnChart_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnChart_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnSignOut_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterBtn(sender);
        }

        private void btnSignOut_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveBtn(sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmDashBoard")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                frmDashBoard frm = new frmDashBoard();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmCustommer")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                frmCustommer frm = new frmCustommer();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmEmployee")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                frmEmployee frm = new frmEmployee();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btnComputers_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmComputer")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                frmComputer frm = new frmComputer();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmCategory")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                frmCategory frm = new frmCategory();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmChart")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                frmChart frm = new frmChart();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            bool isExits = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmShowEmployee")
                {
                    f.Activate();
                    isExits = true;
                    break;
                }
            }
            if (!isExits)
            {
                frmShowEmployee frm = new frmShowEmployee();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
        }

        private void pnTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmMaint_Load(object sender, EventArgs e)
        {
            frmDashBoard frmDB = new frmDashBoard();
            frmDB.MdiParent = this;
            frmDB.Show();
            ActiveBtn(btnHome);


        }
    }
}
