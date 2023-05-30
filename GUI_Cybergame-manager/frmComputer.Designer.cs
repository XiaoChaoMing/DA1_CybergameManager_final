namespace GUI_Cybergame_manager
{
    partial class frmComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtComputerSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRepairComputer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteComputer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddComputer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvComputer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1518, 790);
            this.guna2Panel2.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.txtComputerSearch);
            this.guna2Panel1.Controls.Add(this.btnRepairComputer);
            this.guna2Panel1.Controls.Add(this.btnDeleteComputer);
            this.guna2Panel1.Controls.Add(this.btnAddComputer);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1518, 92);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1102, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(43, 37);
            this.btnSearch.TabIndex = 6;
            // 
            // txtComputerSearch
            // 
            this.txtComputerSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComputerSearch.DefaultText = "";
            this.txtComputerSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComputerSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComputerSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComputerSearch.DisabledState.Parent = this.txtComputerSearch;
            this.txtComputerSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComputerSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComputerSearch.FocusedState.Parent = this.txtComputerSearch;
            this.txtComputerSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComputerSearch.HoverState.Parent = this.txtComputerSearch;
            this.txtComputerSearch.Location = new System.Drawing.Point(771, 31);
            this.txtComputerSearch.Name = "txtComputerSearch";
            this.txtComputerSearch.PasswordChar = '\0';
            this.txtComputerSearch.PlaceholderText = "";
            this.txtComputerSearch.SelectedText = "";
            this.txtComputerSearch.ShadowDecoration.Parent = this.txtComputerSearch;
            this.txtComputerSearch.Size = new System.Drawing.Size(325, 36);
            this.txtComputerSearch.TabIndex = 5;
            // 
            // btnRepairComputer
            // 
            this.btnRepairComputer.CheckedState.Parent = this.btnRepairComputer;
            this.btnRepairComputer.CustomImages.Parent = this.btnRepairComputer;
            this.btnRepairComputer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.btnRepairComputer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRepairComputer.ForeColor = System.Drawing.Color.White;
            this.btnRepairComputer.HoverState.Parent = this.btnRepairComputer;
            this.btnRepairComputer.Location = new System.Drawing.Point(484, 22);
            this.btnRepairComputer.Name = "btnRepairComputer";
            this.btnRepairComputer.ShadowDecoration.Parent = this.btnRepairComputer;
            this.btnRepairComputer.Size = new System.Drawing.Size(180, 45);
            this.btnRepairComputer.TabIndex = 4;
            this.btnRepairComputer.Text = "Sửa thông tin máy";
            // 
            // btnDeleteComputer
            // 
            this.btnDeleteComputer.CheckedState.Parent = this.btnDeleteComputer;
            this.btnDeleteComputer.CustomImages.Parent = this.btnDeleteComputer;
            this.btnDeleteComputer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.btnDeleteComputer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteComputer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteComputer.HoverState.Parent = this.btnDeleteComputer;
            this.btnDeleteComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteComputer.Image")));
            this.btnDeleteComputer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteComputer.Location = new System.Drawing.Point(247, 23);
            this.btnDeleteComputer.Name = "btnDeleteComputer";
            this.btnDeleteComputer.ShadowDecoration.Parent = this.btnDeleteComputer;
            this.btnDeleteComputer.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteComputer.TabIndex = 1;
            this.btnDeleteComputer.Text = "Xóa máy";
            this.btnDeleteComputer.Click += new System.EventHandler(this.btnDeleteComputer_Click);
            // 
            // btnAddComputer
            // 
            this.btnAddComputer.CheckedState.Parent = this.btnAddComputer;
            this.btnAddComputer.CustomImages.Parent = this.btnAddComputer;
            this.btnAddComputer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.btnAddComputer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddComputer.ForeColor = System.Drawing.Color.White;
            this.btnAddComputer.HoverState.Parent = this.btnAddComputer;
            this.btnAddComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComputer.Image")));
            this.btnAddComputer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddComputer.Location = new System.Drawing.Point(26, 23);
            this.btnAddComputer.Name = "btnAddComputer";
            this.btnAddComputer.ShadowDecoration.Parent = this.btnAddComputer;
            this.btnAddComputer.Size = new System.Drawing.Size(180, 45);
            this.btnAddComputer.TabIndex = 0;
            this.btnAddComputer.Text = "Thêm máy";
            this.btnAddComputer.Click += new System.EventHandler(this.btnAddComputer_Click_1);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.dgvComputer);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 92);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1518, 698);
            this.guna2Panel3.TabIndex = 4;
            // 
            // dgvComputer
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvComputer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvComputer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComputer.BackgroundColor = System.Drawing.Color.White;
            this.dgvComputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComputer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvComputer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvComputer.ColumnHeadersHeight = 25;
            this.dgvComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComputer.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComputer.EnableHeadersVisualStyles = false;
            this.dgvComputer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComputer.Location = new System.Drawing.Point(0, 0);
            this.dgvComputer.Name = "dgvComputer";
            this.dgvComputer.RowHeadersVisible = false;
            this.dgvComputer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputer.Size = new System.Drawing.Size(1518, 698);
            this.dgvComputer.TabIndex = 0;
            this.dgvComputer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvComputer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComputer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvComputer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvComputer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvComputer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvComputer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvComputer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComputer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvComputer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComputer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvComputer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvComputer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComputer.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvComputer.ThemeStyle.ReadOnly = false;
            this.dgvComputer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComputer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvComputer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvComputer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvComputer.ThemeStyle.RowsStyle.Height = 22;
            this.dgvComputer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComputer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 790);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComputer";
            this.Text = "frmComputer";
            this.Load += new System.EventHandler(this.frmComputer_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtComputerSearch;
        private Guna.UI2.WinForms.Guna2Button btnRepairComputer;
        private Guna.UI2.WinForms.Guna2Button btnDeleteComputer;
        private Guna.UI2.WinForms.Guna2Button btnAddComputer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvComputer;
    }
}