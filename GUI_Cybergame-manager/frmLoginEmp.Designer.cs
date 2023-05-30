namespace GUI_Cybergame_manager
{
    partial class frmLoginEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginEmp));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtPassEmp = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAccountEmp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbbPermission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Controls.Add(this.cbbPermission);
            this.guna2GradientPanel1.Controls.Add(this.btnClose);
            this.guna2GradientPanel1.Controls.Add(this.txtPassEmp);
            this.guna2GradientPanel1.Controls.Add(this.cbShowPass);
            this.guna2GradientPanel1.Controls.Add(this.btnLogin);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.txtAccountEmp);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Fuchsia;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(558, 554);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // txtPassEmp
            // 
            this.txtPassEmp.BackColor = System.Drawing.Color.Transparent;
            this.txtPassEmp.BorderRadius = 15;
            this.txtPassEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassEmp.DefaultText = "";
            this.txtPassEmp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassEmp.DisabledState.Parent = this.txtPassEmp;
            this.txtPassEmp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassEmp.FocusedState.Parent = this.txtPassEmp;
            this.txtPassEmp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassEmp.HoverState.Parent = this.txtPassEmp;
            this.txtPassEmp.Location = new System.Drawing.Point(99, 217);
            this.txtPassEmp.Name = "txtPassEmp";
            this.txtPassEmp.PasswordChar = '\0';
            this.txtPassEmp.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPassEmp.PlaceholderText = "Mật khẩu";
            this.txtPassEmp.SelectedText = "";
            this.txtPassEmp.ShadowDecoration.Parent = this.txtPassEmp;
            this.txtPassEmp.Size = new System.Drawing.Size(361, 49);
            this.txtPassEmp.TabIndex = 15;
            this.txtPassEmp.UseSystemPasswordChar = true;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.CheckedState.BorderRadius = 2;
            this.cbShowPass.CheckedState.BorderThickness = 0;
            this.cbShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPass.ForeColor = System.Drawing.Color.Black;
            this.cbShowPass.Location = new System.Drawing.Point(99, 355);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(144, 20);
            this.cbShowPass.TabIndex = 14;
            this.cbShowPass.Text = "Hiển thị mật khẩu";
            this.cbShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.UncheckedState.BorderRadius = 2;
            this.cbShowPass.UncheckedState.BorderThickness = 0;
            this.cbShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.UseVisualStyleBackColor = false;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(191, 426);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 53);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Paytone One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SkyBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(208, 70);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(173, 45);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Đăng Nhập";
            // 
            // txtAccountEmp
            // 
            this.txtAccountEmp.BackColor = System.Drawing.Color.Transparent;
            this.txtAccountEmp.BorderRadius = 15;
            this.txtAccountEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountEmp.DefaultText = "";
            this.txtAccountEmp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountEmp.DisabledState.Parent = this.txtAccountEmp;
            this.txtAccountEmp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountEmp.FocusedState.Parent = this.txtAccountEmp;
            this.txtAccountEmp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountEmp.HoverState.Parent = this.txtAccountEmp;
            this.txtAccountEmp.Location = new System.Drawing.Point(99, 139);
            this.txtAccountEmp.Name = "txtAccountEmp";
            this.txtAccountEmp.PasswordChar = '\0';
            this.txtAccountEmp.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtAccountEmp.PlaceholderText = "Tài khoản";
            this.txtAccountEmp.SelectedText = "";
            this.txtAccountEmp.ShadowDecoration.Parent = this.txtAccountEmp;
            this.txtAccountEmp.Size = new System.Drawing.Size(361, 49);
            this.txtAccountEmp.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 25;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(505, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 16;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbbPermission
            // 
            this.cbbPermission.BackColor = System.Drawing.Color.Transparent;
            this.cbbPermission.BorderRadius = 15;
            this.cbbPermission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPermission.FocusedColor = System.Drawing.Color.Empty;
            this.cbbPermission.FocusedState.Parent = this.cbbPermission;
            this.cbbPermission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbPermission.FormattingEnabled = true;
            this.cbbPermission.HoverState.Parent = this.cbbPermission;
            this.cbbPermission.ItemHeight = 30;
            this.cbbPermission.Items.AddRange(new object[] {
            "Quản lý",
            "Thu ngân"});
            this.cbbPermission.ItemsAppearance.Parent = this.cbbPermission;
            this.cbbPermission.Location = new System.Drawing.Point(99, 294);
            this.cbbPermission.Name = "cbbPermission";
            this.cbbPermission.ShadowDecoration.Parent = this.cbbPermission;
            this.cbbPermission.Size = new System.Drawing.Size(140, 36);
            this.cbbPermission.TabIndex = 17;
            // 
            // frmLoginEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 554);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginEmp";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassEmp;
        private Guna.UI2.WinForms.Guna2CheckBox cbShowPass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountEmp;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPermission;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}