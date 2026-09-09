namespace Dental_Clinic_Project.Appointments
{
    partial class frmListAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblcount = new ReaLTaiizor.Controls.DungeonLabel();
            this.bbbvb = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvAppoin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsAppoin = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnAddUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbdateFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePacker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoin)).BeginInit();
            this.cmsAppoin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblcount.Location = new System.Drawing.Point(65, 609);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(26, 18);
            this.lblcount.TabIndex = 59;
            this.lblcount.Text = "???";
            // 
            // bbbvb
            // 
            this.bbbvb.AutoSize = true;
            this.bbbvb.BackColor = System.Drawing.Color.Transparent;
            this.bbbvb.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbbvb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bbbvb.Location = new System.Drawing.Point(10, 609);
            this.bbbvb.Name = "bbbvb";
            this.bbbvb.Size = new System.Drawing.Size(58, 18);
            this.bbbvb.TabIndex = 58;
            this.bbbvb.Text = "Count:";
            // 
            // txtFilter
            // 
            this.txtFilter.Animated = true;
            this.txtFilter.AutoRoundedCorners = true;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Location = new System.Drawing.Point(263, 156);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(165, 36);
            this.txtFilter.TabIndex = 56;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgvAppoin
            // 
            this.dgvAppoin.AllowUserToAddRows = false;
            this.dgvAppoin.AllowUserToDeleteRows = false;
            this.dgvAppoin.AllowUserToResizeColumns = false;
            this.dgvAppoin.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvAppoin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppoin.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAppoin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppoin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppoin.ColumnHeadersHeight = 35;
            this.dgvAppoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppoin.ContextMenuStrip = this.cmsAppoin;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppoin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppoin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAppoin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvAppoin.Location = new System.Drawing.Point(12, 198);
            this.dgvAppoin.Name = "dgvAppoin";
            this.dgvAppoin.ReadOnly = true;
            this.dgvAppoin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppoin.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppoin.RowHeadersVisible = false;
            this.dgvAppoin.RowTemplate.ReadOnly = true;
            this.dgvAppoin.Size = new System.Drawing.Size(825, 395);
            this.dgvAppoin.TabIndex = 55;
            this.dgvAppoin.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvAppoin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvAppoin.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAppoin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvAppoin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvAppoin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAppoin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppoin.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAppoin.ThemeStyle.ReadOnly = true;
            this.dgvAppoin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvAppoin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppoin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAppoin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvAppoin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsAppoin
            // 
            this.cmsAppoin.BackColor = System.Drawing.SystemColors.Menu;
            this.cmsAppoin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAppoin.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsAppoin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsAppoin.Name = "cmsDentists";
            this.cmsAppoin.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsAppoin.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsAppoin.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsAppoin.RenderStyle.ColorTable = null;
            this.cmsAppoin.RenderStyle.RoundedEdges = true;
            this.cmsAppoin.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsAppoin.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsAppoin.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsAppoin.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsAppoin.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsAppoin.Size = new System.Drawing.Size(195, 134);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.appointment__2_;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.appointment__3_;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.appointment;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmbfilter
            // 
            this.cmbfilter.AutoRoundedCorners = true;
            this.cmbfilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbfilter.BorderRadius = 17;
            this.cmbfilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbfilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbfilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbfilter.ItemHeight = 30;
            this.cmbfilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "Dentist Name",
            "Patient Name",
            "Appointment Date",
            "status"});
            this.cmbfilter.Location = new System.Drawing.Point(90, 156);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(167, 36);
            this.cmbfilter.TabIndex = 54;
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bigLabel1.Location = new System.Drawing.Point(311, 117);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(220, 36);
            this.bigLabel1.TabIndex = 53;
            this.bigLabel1.Text = "Appointments";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dungeonLabel1.Location = new System.Drawing.Point(17, 165);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(67, 18);
            this.dungeonLabel1.TabIndex = 60;
            this.dungeonLabel1.Text = "Filter By";
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
            this.btnAddUpdate.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnAddUpdate.FillColor2 = System.Drawing.Color.LightBlue;
            this.btnAddUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.ForeColor = System.Drawing.Color.Azure;
            this.btnAddUpdate.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAddUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUpdate.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddUpdate.Location = new System.Drawing.Point(709, 147);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.ShadowDecoration.Color = System.Drawing.Color.MediumAquamarine;
            this.btnAddUpdate.Size = new System.Drawing.Size(142, 45);
            this.btnAddUpdate.TabIndex = 57;
            this.btnAddUpdate.Text = "Add Appointment";
            this.btnAddUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.AutoRoundedCorners = true;
            this.cmbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cmbIsActive.BorderRadius = 17;
            this.cmbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIsActive.ItemHeight = 30;
            this.cmbIsActive.Items.AddRange(new object[] {
            "None",
            "scheduled",
            "completed",
            "cancelled"});
            this.cmbIsActive.Location = new System.Drawing.Point(263, 156);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(165, 36);
            this.cmbIsActive.TabIndex = 62;
            this.cmbIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbIsActive_SelectedIndexChanged);
            // 
            // cmbdateFilter
            // 
            this.cmbdateFilter.AutoRoundedCorners = true;
            this.cmbdateFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbdateFilter.BorderRadius = 17;
            this.cmbdateFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdateFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbdateFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbdateFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbdateFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbdateFilter.ItemHeight = 30;
            this.cmbdateFilter.Items.AddRange(new object[] {
            "None",
            "Today",
            "this month",
            "this year",
            "Specific Date"});
            this.cmbdateFilter.Location = new System.Drawing.Point(263, 156);
            this.cmbdateFilter.Name = "cmbdateFilter";
            this.cmbdateFilter.Size = new System.Drawing.Size(165, 36);
            this.cmbdateFilter.TabIndex = 63;
            this.cmbdateFilter.SelectedIndexChanged += new System.EventHandler(this.cmbdateFilter_SelectedIndexChanged);
            // 
            // dateTimePacker
            // 
            this.dateTimePacker.Animated = true;
            this.dateTimePacker.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePacker.BorderRadius = 20;
            this.dateTimePacker.Checked = true;
            this.dateTimePacker.FillColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePacker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePacker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePacker.Location = new System.Drawing.Point(434, 156);
            this.dateTimePacker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePacker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePacker.Name = "dateTimePacker";
            this.dateTimePacker.ShadowDecoration.BorderRadius = 20;
            this.dateTimePacker.ShadowDecoration.Color = System.Drawing.Color.LightBlue;
            this.dateTimePacker.ShadowDecoration.Enabled = true;
            this.dateTimePacker.Size = new System.Drawing.Size(200, 36);
            this.dateTimePacker.TabIndex = 65;
            this.dateTimePacker.Value = new System.DateTime(2026, 8, 26, 19, 57, 18, 86);
            this.dateTimePacker.ValueChanged += new System.EventHandler(this.dateTimePacker_ValueChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.LightSlateGray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(671, 156);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 61;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Project.Properties.Resources.istockphoto_1887268593_1024x1024;
            this.pictureBox1.Location = new System.Drawing.Point(326, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // frmListAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(849, 636);
            this.Controls.Add(this.dateTimePacker);
            this.Controls.Add(this.cmbdateFilter);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.bbbvb);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvAppoin);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListAppointments";
            this.Load += new System.EventHandler(this.frmListAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoin)).EndInit();
            this.cmsAppoin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel lblcount;
        private ReaLTaiizor.Controls.DungeonLabel bbbvb;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppoin;
        private Guna.UI2.WinForms.Guna2ComboBox cmbfilter;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIsActive;
        private Guna.UI2.WinForms.Guna2ComboBox cmbdateFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePacker;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsAppoin;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}