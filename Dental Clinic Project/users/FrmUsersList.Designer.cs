namespace Dental_Clinic_Project.users
{
    partial class FrmUsersList
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
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.lblcount = new ReaLTaiizor.Controls.DungeonLabel();
            this.bbbvb = new ReaLTaiizor.Controls.DungeonLabel();
            this.cmbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dungeonLabel1.Location = new System.Drawing.Point(12, 173);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(67, 18);
            this.dungeonLabel1.TabIndex = 51;
            this.dungeonLabel1.Text = "Filter By";
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
            this.txtFilter.Location = new System.Drawing.Point(231, 164);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(151, 36);
            this.txtFilter.TabIndex = 50;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
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
            "User Name",
            "IsActive",
            "Role"});
            this.cmbfilter.Location = new System.Drawing.Point(85, 164);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(140, 36);
            this.cmbfilter.TabIndex = 49;
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 35;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 215);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUsers.Size = new System.Drawing.Size(864, 395);
            this.dgvUsers.TabIndex = 53;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmsUsers
            // 
            this.cmsUsers.BackColor = System.Drawing.SystemColors.Menu;
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsUsers.Name = "cmsDentists";
            this.cmsUsers.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.ColorTable = null;
            this.cmsUsers.RenderStyle.RoundedEdges = true;
            this.cmsUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUsers.Size = new System.Drawing.Size(164, 112);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.administrator_info;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.administrator_reload;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.administrator_close;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bigLabel1.Location = new System.Drawing.Point(371, 125);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(95, 36);
            this.bigLabel1.TabIndex = 54;
            this.bigLabel1.Text = "Users";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblcount.Location = new System.Drawing.Point(52, 622);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(26, 18);
            this.lblcount.TabIndex = 56;
            this.lblcount.Text = "???";
            // 
            // bbbvb
            // 
            this.bbbvb.AutoSize = true;
            this.bbbvb.BackColor = System.Drawing.Color.Transparent;
            this.bbbvb.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbbvb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bbbvb.Location = new System.Drawing.Point(-3, 622);
            this.bbbvb.Name = "bbbvb";
            this.bbbvb.Size = new System.Drawing.Size(58, 18);
            this.bbbvb.TabIndex = 55;
            this.bbbvb.Text = "Count:";
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
            "true",
            "false"});
            this.cmbIsActive.Location = new System.Drawing.Point(231, 164);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(86, 36);
            this.cmbIsActive.TabIndex = 57;
            this.cmbIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbIsActive_SelectedIndexChanged);
            // 
            // cmbRole
            // 
            this.cmbRole.AutoRoundedCorners = true;
            this.cmbRole.BackColor = System.Drawing.Color.Transparent;
            this.cmbRole.BorderRadius = 17;
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRole.ItemHeight = 30;
            this.cmbRole.Items.AddRange(new object[] {
            "ADMIN",
            "DOCTOR",
            "RECEPTIONIST"});
            this.cmbRole.Location = new System.Drawing.Point(231, 164);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(151, 36);
            this.cmbRole.TabIndex = 58;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
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
            this.btnAddUpdate.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAddUpdate.FillColor2 = System.Drawing.Color.LightSteelBlue;
            this.btnAddUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.btnAddUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddUpdate.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddUpdate.HoverState.FillColor2 = System.Drawing.Color.LightSteelBlue;
            this.btnAddUpdate.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddUpdate.HoverState.Image = global::Dental_Clinic_Project.Properties.Resources.administrator_add;
            this.btnAddUpdate.Image = global::Dental_Clinic_Project.Properties.Resources.administrator_add;
            this.btnAddUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUpdate.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddUpdate.Location = new System.Drawing.Point(677, 164);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.ShadowDecoration.Color = System.Drawing.Color.MediumAquamarine;
            this.btnAddUpdate.Size = new System.Drawing.Size(176, 45);
            this.btnAddUpdate.TabIndex = 52;
            this.btnAddUpdate.Text = "Add User";
            this.btnAddUpdate.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Dental_Clinic_Project.Properties.Resources.istockphoto_1350866742_1024x1024;
            this.pictureBox1.Location = new System.Drawing.Point(328, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(865, 649);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.bbbvb);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsersList";
            this.Text = "FrmUsersList";
            this.Load += new System.EventHandler(this.FrmUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbfilter;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonLabel lblcount;
        private ReaLTaiizor.Controls.DungeonLabel bbbvb;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIsActive;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRole;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}