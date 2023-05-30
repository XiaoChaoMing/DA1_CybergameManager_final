using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Cybergame_users
{
    public partial class frmLockScreen : Form
    {
        private static frmLockScreen _instance;
        public frmLockScreen()
        {
            InitializeComponent();
            this.TopMost = true;
            this.ShowInTaskbar = false;
            _instance = this;
        }
        public static void HideLockSC()
        {
            _instance.Hide();
        }
        public static void ShowLockSC()
        {
            _instance.Show();
        }
        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            frmLoginUser frm = new frmLoginUser();
            frm.TopMost = true;
            frm.Show();
        }

        
    }
}
