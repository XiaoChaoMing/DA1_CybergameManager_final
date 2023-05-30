namespace GUI_Cybergame_manager
{
    partial class frmFillMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFillMoney));
            this.btnConfirmFill = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFillMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCustomerAcc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMoneyRemaint = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.time = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLeftTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmFill
            // 
            this.btnConfirmFill.CheckedState.Parent = this.btnConfirmFill;
            this.btnConfirmFill.CustomImages.Parent = this.btnConfirmFill;
            this.btnConfirmFill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmFill.ForeColor = System.Drawing.Color.White;
            this.btnConfirmFill.HoverState.Parent = this.btnConfirmFill;
            this.btnConfirmFill.Location = new System.Drawing.Point(569, 268);
            this.btnConfirmFill.Name = "btnConfirmFill";
            this.btnConfirmFill.ShadowDecoration.Parent = this.btnConfirmFill;
            this.btnConfirmFill.Size = new System.Drawing.Size(180, 45);
            this.btnConfirmFill.TabIndex = 11;
            this.btnConfirmFill.Text = "Xác nhận";
            this.btnConfirmFill.Click += new System.EventHandler(this.btnConfirmFill_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(67, 282);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(93, 20);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Số tiền nạp:";
            // 
            // txtFillMoney
            // 
            this.txtFillMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFillMoney.DefaultText = "";
            this.txtFillMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFillMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFillMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFillMoney.DisabledState.Parent = this.txtFillMoney;
            this.txtFillMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFillMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFillMoney.FocusedState.Parent = this.txtFillMoney;
            this.txtFillMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFillMoney.HoverState.Parent = this.txtFillMoney;
            this.txtFillMoney.Location = new System.Drawing.Point(168, 273);
            this.txtFillMoney.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFillMoney.Name = "txtFillMoney";
            this.txtFillMoney.PasswordChar = '\0';
            this.txtFillMoney.PlaceholderText = "";
            this.txtFillMoney.SelectedText = "";
            this.txtFillMoney.ShadowDecoration.Parent = this.txtFillMoney;
            this.txtFillMoney.Size = new System.Drawing.Size(339, 40);
            this.txtFillMoney.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(50, 99);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(110, 20);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Tên tài khoản:";
            // 
            // txtCustomerAcc
            // 
            this.txtCustomerAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerAcc.DefaultText = "";
            this.txtCustomerAcc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerAcc.DisabledState.Parent = this.txtCustomerAcc;
            this.txtCustomerAcc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerAcc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerAcc.FocusedState.Parent = this.txtCustomerAcc;
            this.txtCustomerAcc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerAcc.HoverState.Parent = this.txtCustomerAcc;
            this.txtCustomerAcc.Location = new System.Drawing.Point(168, 89);
            this.txtCustomerAcc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustomerAcc.Name = "txtCustomerAcc";
            this.txtCustomerAcc.PasswordChar = '\0';
            this.txtCustomerAcc.PlaceholderText = "";
            this.txtCustomerAcc.ReadOnly = true;
            this.txtCustomerAcc.SelectedText = "";
            this.txtCustomerAcc.ShadowDecoration.Parent = this.txtCustomerAcc;
            this.txtCustomerAcc.Size = new System.Drawing.Size(339, 40);
            this.txtCustomerAcc.TabIndex = 12;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(44, 159);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(116, 20);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Số tiền còn lại:";
            // 
            // txtMoneyRemaint
            // 
            this.txtMoneyRemaint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneyRemaint.DefaultText = "";
            this.txtMoneyRemaint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoneyRemaint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoneyRemaint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoneyRemaint.DisabledState.Parent = this.txtMoneyRemaint;
            this.txtMoneyRemaint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoneyRemaint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneyRemaint.FocusedState.Parent = this.txtMoneyRemaint;
            this.txtMoneyRemaint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneyRemaint.HoverState.Parent = this.txtMoneyRemaint;
            this.txtMoneyRemaint.Location = new System.Drawing.Point(168, 149);
            this.txtMoneyRemaint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMoneyRemaint.Name = "txtMoneyRemaint";
            this.txtMoneyRemaint.PasswordChar = '\0';
            this.txtMoneyRemaint.PlaceholderText = "";
            this.txtMoneyRemaint.ReadOnly = true;
            this.txtMoneyRemaint.SelectedText = "";
            this.txtMoneyRemaint.ShadowDecoration.Parent = this.txtMoneyRemaint;
            this.txtMoneyRemaint.Size = new System.Drawing.Size(339, 40);
            this.txtMoneyRemaint.TabIndex = 14;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(53, 38);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(107, 20);
            this.guna2HtmlLabel4.TabIndex = 17;
            this.guna2HtmlLabel4.Text = "id Thành viên:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.DisabledState.Parent = this.txtCustomerID;
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.FocusedState.Parent = this.txtCustomerID;
            this.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.HoverState.Parent = this.txtCustomerID;
            this.txtCustomerID.Location = new System.Drawing.Point(168, 29);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.ShadowDecoration.Parent = this.txtCustomerID;
            this.txtCustomerID.Size = new System.Drawing.Size(339, 40);
            this.txtCustomerID.TabIndex = 16;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(28, 218);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(132, 20);
            this.time.TabIndex = 19;
            this.time.Text = "Thời gian còn lại:";
            // 
            // txtLeftTime
            // 
            this.txtLeftTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLeftTime.DefaultText = "";
            this.txtLeftTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLeftTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLeftTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLeftTime.DisabledState.Parent = this.txtLeftTime;
            this.txtLeftTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLeftTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLeftTime.FocusedState.Parent = this.txtLeftTime;
            this.txtLeftTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLeftTime.HoverState.Parent = this.txtLeftTime;
            this.txtLeftTime.Location = new System.Drawing.Point(168, 209);
            this.txtLeftTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLeftTime.Name = "txtLeftTime";
            this.txtLeftTime.PasswordChar = '\0';
            this.txtLeftTime.PlaceholderText = "";
            this.txtLeftTime.ReadOnly = true;
            this.txtLeftTime.SelectedText = "";
            this.txtLeftTime.ShadowDecoration.Parent = this.txtLeftTime;
            this.txtLeftTime.Size = new System.Drawing.Size(339, 40);
            this.txtLeftTime.TabIndex = 18;
            // 
            // frmFillMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(804, 357);
            this.Controls.Add(this.time);
            this.Controls.Add(this.txtLeftTime);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtMoneyRemaint);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtCustomerAcc);
            this.Controls.Add(this.btnConfirmFill);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtFillMoney);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFillMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nạp tiền";
            this.Load += new System.EventHandler(this.frmFillMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnConfirmFill;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtFillMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerAcc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMoneyRemaint;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID;
        private Guna.UI2.WinForms.Guna2HtmlLabel time;
        private Guna.UI2.WinForms.Guna2TextBox txtLeftTime;
    }
}