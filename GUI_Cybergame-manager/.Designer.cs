namespace GUI_Cybergame_manager
{
    partial class frmMaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaint));
            this.pnSideBarContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnSideBarControl = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.pnSideBarMaint = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChart = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnComputers = new Guna.UI2.WinForms.Guna2Button();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnTittleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTabName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnSideBarContainer.SuspendLayout();
            this.pnSideBarControl.SuspendLayout();
            this.pnSideBarMaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnTittleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSideBarContainer
            // 
            this.pnSideBarContainer.BackColor = System.Drawing.Color.Black;
            this.pnSideBarContainer.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnSideBarContainer.Controls.Add(this.pnSideBarControl);
            this.pnSideBarContainer.Controls.Add(this.pnSideBarMaint);
            this.pnSideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideBarContainer.Location = new System.Drawing.Point(0, 0);
            this.pnSideBarContainer.Name = "pnSideBarContainer";
            this.pnSideBarContainer.ShadowDecoration.Parent = this.pnSideBarContainer;
            this.pnSideBarContainer.Size = new System.Drawing.Size(111, 974);
            this.pnSideBarContainer.TabIndex = 0;
            // 
            // pnSideBarControl
            // 
            this.pnSideBarControl.Controls.Add(this.btnSettings);
            this.pnSideBarControl.Controls.Add(this.btnSignOut);
            this.pnSideBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideBarControl.Location = new System.Drawing.Point(0, 616);
            this.pnSideBarControl.Name = "pnSideBarControl";
            this.pnSideBarControl.Padding = new System.Windows.Forms.Padding(10);
            this.pnSideBarControl.ShadowDecoration.Parent = this.pnSideBarControl;
            this.pnSideBarControl.Size = new System.Drawing.Size(111, 358);
            this.pnSideBarControl.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSettings.Location = new System.Drawing.Point(10, 220);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(91, 45);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // btnSignOut
            // 
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.btnSignOut.FillColor = System.Drawing.Color.Transparent;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignOut.Location = new System.Drawing.Point(10, 282);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(91, 45);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            this.btnSignOut.MouseEnter += new System.EventHandler(this.btnSignOut_MouseEnter);
            this.btnSignOut.MouseLeave += new System.EventHandler(this.btnSignOut_MouseLeave);
            // 
            // pnSideBarMaint
            // 
            this.pnSideBarMaint.Controls.Add(this.btnChart);
            this.pnSideBarMaint.Controls.Add(this.btnFoodMenu);
            this.pnSideBarMaint.Controls.Add(this.btnEmployee);
            this.pnSideBarMaint.Controls.Add(this.btnCustomers);
            this.pnSideBarMaint.Controls.Add(this.btnHome);
            this.pnSideBarMaint.Controls.Add(this.btnComputers);
            this.pnSideBarMaint.Controls.Add(this.imgLogo);
            this.pnSideBarMaint.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSideBarMaint.Location = new System.Drawing.Point(0, 0);
            this.pnSideBarMaint.Name = "pnSideBarMaint";
            this.pnSideBarMaint.Padding = new System.Windows.Forms.Padding(10);
            this.pnSideBarMaint.ShadowDecoration.Parent = this.pnSideBarMaint;
            this.pnSideBarMaint.Size = new System.Drawing.Size(111, 616);
            this.pnSideBarMaint.TabIndex = 0;
            // 
            // btnChart
            // 
            this.btnChart.CheckedState.Parent = this.btnChart;
            this.btnChart.CustomImages.Parent = this.btnChart;
            this.btnChart.FillColor = System.Drawing.Color.Transparent;
            this.btnChart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChart.ForeColor = System.Drawing.Color.White;
            this.btnChart.HoverState.Parent = this.btnChart;
            this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            this.btnChart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnChart.Location = new System.Drawing.Point(10, 412);
            this.btnChart.Name = "btnChart";
            this.btnChart.ShadowDecoration.Parent = this.btnChart;
            this.btnChart.Size = new System.Drawing.Size(91, 45);
            this.btnChart.TabIndex = 5;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            this.btnChart.MouseEnter += new System.EventHandler(this.btnChart_MouseEnter);
            this.btnChart.MouseLeave += new System.EventHandler(this.btnChart_MouseLeave);
            // 
            // btnFoodMenu
            // 
            this.btnFoodMenu.CheckedState.Parent = this.btnFoodMenu;
            this.btnFoodMenu.CustomImages.Parent = this.btnFoodMenu;
            this.btnFoodMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnFoodMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFoodMenu.ForeColor = System.Drawing.Color.White;
            this.btnFoodMenu.HoverState.Parent = this.btnFoodMenu;
            this.btnFoodMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodMenu.Image")));
            this.btnFoodMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFoodMenu.Location = new System.Drawing.Point(10, 353);
            this.btnFoodMenu.Name = "btnFoodMenu";
            this.btnFoodMenu.ShadowDecoration.Parent = this.btnFoodMenu;
            this.btnFoodMenu.Size = new System.Drawing.Size(91, 45);
            this.btnFoodMenu.TabIndex = 4;
            this.btnFoodMenu.Click += new System.EventHandler(this.btnFoodMenu_Click);
            this.btnFoodMenu.MouseEnter += new System.EventHandler(this.btnFoodMenu_MouseEnter);
            this.btnFoodMenu.MouseLeave += new System.EventHandler(this.btnFoodMenu_MouseLeave);
            // 
            // btnEmployee
            // 
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployee.Location = new System.Drawing.Point(10, 235);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(91, 45);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            this.btnEmployee.MouseEnter += new System.EventHandler(this.btnEmployee_MouseEnter);
            this.btnEmployee.MouseLeave += new System.EventHandler(this.btnEmployee_MouseLeave);
            // 
            // btnCustomers
            // 
            this.btnCustomers.CheckedState.Parent = this.btnCustomers;
            this.btnCustomers.CustomImages.Parent = this.btnCustomers;
            this.btnCustomers.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.Parent = this.btnCustomers;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomers.Location = new System.Drawing.Point(10, 176);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ShadowDecoration.Parent = this.btnCustomers;
            this.btnCustomers.Size = new System.Drawing.Size(91, 45);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            this.btnCustomers.MouseEnter += new System.EventHandler(this.btnCustomers_MouseEnter);
            this.btnCustomers.MouseLeave += new System.EventHandler(this.btnCustomers_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(10, 117);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(91, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnComputers
            // 
            this.btnComputers.CheckedState.Parent = this.btnComputers;
            this.btnComputers.CustomImages.Parent = this.btnComputers;
            this.btnComputers.FillColor = System.Drawing.Color.Transparent;
            this.btnComputers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComputers.ForeColor = System.Drawing.Color.White;
            this.btnComputers.HoverState.Parent = this.btnComputers;
            this.btnComputers.Image = ((System.Drawing.Image)(resources.GetObject("btnComputers.Image")));
            this.btnComputers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnComputers.Location = new System.Drawing.Point(10, 294);
            this.btnComputers.Name = "btnComputers";
            this.btnComputers.ShadowDecoration.Parent = this.btnComputers;
            this.btnComputers.Size = new System.Drawing.Size(91, 45);
            this.btnComputers.TabIndex = 3;
            this.btnComputers.Click += new System.EventHandler(this.btnComputers_Click);
            this.btnComputers.MouseEnter += new System.EventHandler(this.btnComputers_MouseEnter);
            this.btnComputers.MouseLeave += new System.EventHandler(this.btnComputers_MouseLeave);
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(10, 10);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.ShadowDecoration.Parent = this.imgLogo;
            this.imgLogo.Size = new System.Drawing.Size(91, 83);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 25;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(1493, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnTittleBar
            // 
            this.pnTittleBar.BackColor = System.Drawing.Color.Black;
            this.pnTittleBar.Controls.Add(this.lbTabName);
            this.pnTittleBar.Controls.Add(this.btnClose);
            this.pnTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTittleBar.Location = new System.Drawing.Point(111, 0);
            this.pnTittleBar.Name = "pnTittleBar";
            this.pnTittleBar.ShadowDecoration.Parent = this.pnTittleBar;
            this.pnTittleBar.Size = new System.Drawing.Size(1555, 100);
            this.pnTittleBar.TabIndex = 3;
            this.pnTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTittleBar_MouseDown);
            // 
            // lbTabName
            // 
            this.lbTabName.BackColor = System.Drawing.Color.Transparent;
            this.lbTabName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabName.ForeColor = System.Drawing.Color.White;
            this.lbTabName.Location = new System.Drawing.Point(34, 46);
            this.lbTabName.Name = "lbTabName";
            this.lbTabName.Size = new System.Drawing.Size(85, 35);
            this.lbTabName.TabIndex = 3;
            this.lbTabName.Text = "Home";
            // 
            // frmMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1666, 974);
            this.Controls.Add(this.pnTittleBar);
            this.Controls.Add(this.pnSideBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMaint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMaint_Load);
            this.pnSideBarContainer.ResumeLayout(false);
            this.pnSideBarControl.ResumeLayout(false);
            this.pnSideBarMaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnTittleBar.ResumeLayout(false);
            this.pnTittleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnSideBarContainer;
        private Guna.UI2.WinForms.Guna2Panel pnSideBarControl;
        private Guna.UI2.WinForms.Guna2Panel pnSideBarMaint;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnChart;
        private Guna.UI2.WinForms.Guna2Button btnFoodMenu;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnComputers;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnTittleBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTabName;
    }
}

