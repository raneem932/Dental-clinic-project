namespace Dental_Clinic_Project
{
    partial class FrmPatients
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.dgvPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PatietsContextMenuStrip1 = new ReaLTaiizor.Controls.HopeContextMenuStrip();
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFilter = new ReaLTaiizor.Controls.DungeonComboBox();
            this.infoIcon1 = new ReaLTaiizor.Controls.InfoIcon();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.bbbvb = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblcount = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.PatietsContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 24;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2BorderlessForm1.BorderRadius = 24;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Teal;
            this.bigLabel1.Location = new System.Drawing.Point(352, 131);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(134, 36);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "Patients";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToResizeColumns = false;
            this.dgvPatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.ColumnHeadersHeight = 35;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPatients.ContextMenuStrip = this.PatietsContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvPatients.Location = new System.Drawing.Point(9, 224);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowTemplate.ReadOnly = true;
            this.dgvPatients.Size = new System.Drawing.Size(853, 356);
            this.dgvPatients.TabIndex = 2;
            this.dgvPatients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvPatients.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPatients.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPatients.ThemeStyle.ReadOnly = true;
            this.dgvPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // PatietsContextMenuStrip1
            // 
            this.PatietsContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.PatietsContextMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.PatietsContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PatietsContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.updateToolStripMenuItem2,
            this.deletePatientToolStripMenuItem});
            this.PatietsContextMenuStrip1.Name = "hopeContextMenuStrip1";
            this.PatietsContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.PatietsContextMenuStrip1.Size = new System.Drawing.Size(141, 78);
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.AutoSize = false;
            this.showInfoToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfoToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.patient_info;
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showInfoToolStripMenuItem.Text = "Show info";
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateToolStripMenuItem2.Image = global::Dental_Clinic_Project.Properties.Resources.patient_refresh__1_;
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(140, 26);
            this.updateToolStripMenuItem2.Text = "Update";
            this.updateToolStripMenuItem2.Click += new System.EventHandler(this.updateToolStripMenuItem2_Click_1);
            // 
            // deletePatientToolStripMenuItem
            // 
            this.deletePatientToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.patient_close__1_;
            this.deletePatientToolStripMenuItem.Name = "deletePatientToolStripMenuItem";
            this.deletePatientToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.deletePatientToolStripMenuItem.Text = "Delete";
            this.deletePatientToolStripMenuItem.Click += new System.EventHandler(this.deletePatientToolStripMenuItem_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbFilter.ColorA = System.Drawing.Color.PaleTurquoise;
            this.cmbFilter.ColorB = System.Drawing.Color.Turquoise;
            this.cmbFilter.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbFilter.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbFilter.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbFilter.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbFilter.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbFilter.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbFilter.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownHeight = 100;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbFilter.IntegralHeight = false;
            this.cmbFilter.ItemHeight = 20;
            this.cmbFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "Name",
            "Gender",
            "Age",
            "Phone",
            "Email",
            "remaining Amount"});
            this.cmbFilter.Location = new System.Drawing.Point(89, 180);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(135, 26);
            this.cmbFilter.StartIndex = 0;
            this.cmbFilter.TabIndex = 8;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // infoIcon1
            // 
            this.infoIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.infoIcon1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.infoIcon1.CircleColor = System.Drawing.Color.Gray;
            this.infoIcon1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.infoIcon1.ForeColor = System.Drawing.Color.Gray;
            this.infoIcon1.Location = new System.Drawing.Point(230, 85);
            this.infoIcon1.Name = "infoIcon1";
            this.infoIcon1.Size = new System.Drawing.Size(33, 33);
            this.infoIcon1.String = "¡";
            this.infoIcon1.TabIndex = 12;
            this.infoIcon1.Text = "infoIcon1";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.Teal;
            this.dungeonLabel1.Location = new System.Drawing.Point(21, 181);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(67, 18);
            this.dungeonLabel1.TabIndex = 24;
            this.dungeonLabel1.Text = "Filter By";
            // 
            // bbbvb
            // 
            this.bbbvb.AutoSize = true;
            this.bbbvb.BackColor = System.Drawing.Color.Transparent;
            this.bbbvb.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbbvb.ForeColor = System.Drawing.Color.Teal;
            this.bbbvb.Location = new System.Drawing.Point(21, 595);
            this.bbbvb.Name = "bbbvb";
            this.bbbvb.Size = new System.Drawing.Size(58, 18);
            this.bbbvb.TabIndex = 25;
            this.bbbvb.Text = "Count:";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.Teal;
            this.lblcount.Location = new System.Drawing.Point(76, 595);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(26, 18);
            this.lblcount.TabIndex = 26;
            this.lblcount.Text = "???";
            // 
            // txtFilter
            // 
            this.txtFilter.BorderRadius = 6;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Location = new System.Drawing.Point(230, 180);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(135, 26);
            this.txtFilter.TabIndex = 27;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Animated = true;
            this.btnAddUpdate.AutoRoundedCorners = true;
            this.btnAddUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUpdate.BorderRadius = 21;
            this.btnAddUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAddUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUpdate.FillColor = System.Drawing.Color.LightBlue;
            this.btnAddUpdate.FillColor2 = System.Drawing.Color.LightCyan;
            this.btnAddUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.btnAddUpdate.ForeColor = System.Drawing.Color.Teal;
            this.btnAddUpdate.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAddUpdate.Image = global::Dental_Clinic_Project.Properties.Resources.patient;
            this.btnAddUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUpdate.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddUpdate.Location = new System.Drawing.Point(686, 161);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.ShadowDecoration.Color = System.Drawing.Color.MediumAquamarine;
            this.btnAddUpdate.Size = new System.Drawing.Size(176, 45);
            this.btnAddUpdate.TabIndex = 29;
            this.btnAddUpdate.Text = "Add Patient";
            this.btnAddUpdate.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Project.Properties.Resources.istockphoto_1932584673_1024x1024;
            this.pictureBox1.Location = new System.Drawing.Point(319, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(865, 649);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.bbbvb);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.infoIcon1);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPatients";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPatients";
            this.Load += new System.EventHandler(this.FrmPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.PatietsContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPatients;
        private ReaLTaiizor.Controls.InfoIcon infoIcon1;
        private ReaLTaiizor.Controls.DungeonComboBox cmbFilter;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel lblcount;
        private ReaLTaiizor.Controls.DungeonLabel bbbvb;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddUpdate;
        private ReaLTaiizor.Controls.HopeContextMenuStrip PatietsContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deletePatientToolStripMenuItem;
    }
}