namespace GUI_Cybergame_manager
{
    partial class frmCustommer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustommer));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMemberSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtMemberSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHistoryPlay = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistoryView = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMember = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCustommers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustommers)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Controls.Add(this.btnRefesh);
            this.guna2Panel1.Controls.Add(this.btnMemberSearch);
            this.guna2Panel1.Controls.Add(this.txtMemberSearch);
            this.guna2Panel1.Controls.Add(this.btnHistoryPlay);
            this.guna2Panel1.Controls.Add(this.btnHistoryView);
            this.guna2Panel1.Controls.Add(this.btnDeleteMember);
            this.guna2Panel1.Controls.Add(this.btnAddMember);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.CheckedState.Parent = this.btnMemberSearch;
            this.btnMemberSearch.CustomImages.Parent = this.btnMemberSearch;
            resources.ApplyResources(this.btnMemberSearch, "btnMemberSearch");
            this.btnMemberSearch.ForeColor = System.Drawing.Color.White;
            this.btnMemberSearch.HoverState.Parent = this.btnMemberSearch;
            this.btnMemberSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberSearch.Image")));
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.ShadowDecoration.Parent = this.btnMemberSearch;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberSearch.DefaultText = "";
            this.txtMemberSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMemberSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMemberSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberSearch.DisabledState.Parent = this.txtMemberSearch;
            this.txtMemberSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberSearch.FocusedState.Parent = this.txtMemberSearch;
            this.txtMemberSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberSearch.HoverState.Parent = this.txtMemberSearch;
            resources.ApplyResources(this.txtMemberSearch, "txtMemberSearch");
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.PasswordChar = '\0';
            this.txtMemberSearch.PlaceholderText = "";
            this.txtMemberSearch.SelectedText = "";
            this.txtMemberSearch.ShadowDecoration.Parent = this.txtMemberSearch;
            // 
            // btnHistoryPlay
            // 
            this.btnHistoryPlay.CheckedState.Parent = this.btnHistoryPlay;
            this.btnHistoryPlay.CustomImages.Parent = this.btnHistoryPlay;
            this.btnHistoryPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            resources.ApplyResources(this.btnHistoryPlay, "btnHistoryPlay");
            this.btnHistoryPlay.ForeColor = System.Drawing.Color.White;
            this.btnHistoryPlay.HoverState.Parent = this.btnHistoryPlay;
            this.btnHistoryPlay.Name = "btnHistoryPlay";
            this.btnHistoryPlay.ShadowDecoration.Parent = this.btnHistoryPlay;
            this.btnHistoryPlay.Click += new System.EventHandler(this.btnHistoryPlay_Click);
            // 
            // btnHistoryView
            // 
            this.btnHistoryView.CheckedState.Parent = this.btnHistoryView;
            this.btnHistoryView.CustomImages.Parent = this.btnHistoryView;
            this.btnHistoryView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            resources.ApplyResources(this.btnHistoryView, "btnHistoryView");
            this.btnHistoryView.ForeColor = System.Drawing.Color.White;
            this.btnHistoryView.HoverState.Parent = this.btnHistoryView;
            this.btnHistoryView.Name = "btnHistoryView";
            this.btnHistoryView.ShadowDecoration.Parent = this.btnHistoryView;
            this.btnHistoryView.Click += new System.EventHandler(this.btnHistoryView_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.CheckedState.Parent = this.btnDeleteMember;
            this.btnDeleteMember.CustomImages.Parent = this.btnDeleteMember;
            this.btnDeleteMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            resources.ApplyResources(this.btnDeleteMember, "btnDeleteMember");
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.HoverState.Parent = this.btnDeleteMember;
            this.btnDeleteMember.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMember.Image")));
            this.btnDeleteMember.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.ShadowDecoration.Parent = this.btnDeleteMember;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.CheckedState.Parent = this.btnAddMember;
            this.btnAddMember.CustomImages.Parent = this.btnAddMember;
            this.btnAddMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            resources.ApplyResources(this.btnAddMember, "btnAddMember");
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.HoverState.Parent = this.btnAddMember;
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.ShadowDecoration.Parent = this.btnAddMember;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvCustommers);
            resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            // 
            // dgvCustommers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustommers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustommers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustommers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustommers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustommers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustommers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustommers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvCustommers, "dgvCustommers");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustommers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustommers.EnableHeadersVisualStyles = false;
            this.dgvCustommers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustommers.Name = "dgvCustommers";
            this.dgvCustommers.ReadOnly = true;
            this.dgvCustommers.RowHeadersVisible = false;
            this.dgvCustommers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustommers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvCustommers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustommers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustommers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustommers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustommers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustommers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustommers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustommers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustommers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustommers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCustommers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustommers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustommers.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCustommers.ThemeStyle.ReadOnly = true;
            this.dgvCustommers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustommers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustommers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCustommers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustommers.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCustommers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustommers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustommers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCustommers_CellFormatting);
            this.dgvCustommers.DoubleClick += new System.EventHandler(this.dgvCustommers_DoubleClick);
            // 
            // btnRefesh
            // 
            this.btnRefesh.CheckedState.Parent = this.btnRefesh;
            this.btnRefesh.CustomImages.Parent = this.btnRefesh;
            resources.ApplyResources(this.btnRefesh, "btnRefesh");
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.HoverState.Parent = this.btnRefesh;
            this.btnRefesh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.Image")));
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.ShadowDecoration.Parent = this.btnRefesh;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // frmCustommer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustommer";
            this.Load += new System.EventHandler(this.frmCustommer_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustommers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAddMember;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustommers;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMember;
        private Guna.UI2.WinForms.Guna2Button btnHistoryPlay;
        private Guna.UI2.WinForms.Guna2Button btnHistoryView;
        private Guna.UI2.WinForms.Guna2Button btnMemberSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtMemberSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
    }
}