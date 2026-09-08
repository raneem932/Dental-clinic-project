namespace Dental_Clinic_Project.Dentists
{
    partial class frmlistDentists
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
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsDentists = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblcount = new ReaLTaiizor.Controls.DungeonLabel();
            this.bbbvb = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnAddUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDent)).BeginInit();
            this.cmsDentists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.txtFilter.Location = new System.Drawing.Point(238, 169);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(200, 36);
            this.txtFilter.TabIndex = 47;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // dgvDent
            // 
            this.dgvDent.AllowUserToAddRows = false;
            this.dgvDent.AllowUserToDeleteRows = false;
            this.dgvDent.AllowUserToResizeColumns = false;
            this.dgvDent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvDent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDent.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDent.ColumnHeadersHeight = 35;
            this.dgvDent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDent.ContextMenuStrip = this.cmsDentists;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvDent.Location = new System.Drawing.Point(0, 211);
            this.dgvDent.Name = "dgvDent";
            this.dgvDent.ReadOnly = true;
            this.dgvDent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDent.RowHeadersVisible = false;
            this.dgvDent.RowTemplate.ReadOnly = true;
            this.dgvDent.Size = new System.Drawing.Size(853, 395);
            this.dgvDent.TabIndex = 46;
            this.dgvDent.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgvDent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvDent.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvDent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgvDent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDent.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDent.ThemeStyle.ReadOnly = true;
            this.dgvDent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvDent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvDent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsDentists
            // 
            this.cmsDentists.BackColor = System.Drawing.SystemColors.Menu;
            this.cmsDentists.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsDentists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsDentists.Name = "cmsDentists";
            this.cmsDentists.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsDentists.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsDentists.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsDentists.RenderStyle.ColorTable = null;
            this.cmsDentists.RenderStyle.RoundedEdges = true;
            this.cmsDentists.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsDentists.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsDentists.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsDentists.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsDentists.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsDentists.Size = new System.Drawing.Size(195, 134);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.doctor_config;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.doctor_refresh;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Dental_Clinic_Project.Properties.Resources.doctor_close;
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
            "full Name",
            "phone",
            "Email",
            "Status",
            "specialization Name"});
            this.cmbfilter.Location = new System.Drawing.Point(92, 169);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(140, 36);
            this.cmbfilter.TabIndex = 45;
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Teal;
            this.bigLabel1.Location = new System.Drawing.Point(359, 134);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(133, 36);
            this.bigLabel1.TabIndex = 44;
            this.bigLabel1.Text = "Dentists";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.Teal;
            this.dungeonLabel1.Location = new System.Drawing.Point(19, 178);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(67, 18);
            this.dungeonLabel1.TabIndex = 48;
            this.dungeonLabel1.Text = "Filter By";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.Teal;
            this.lblcount.Location = new System.Drawing.Point(67, 622);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(26, 18);
            this.lblcount.TabIndex = 51;
            this.lblcount.Text = "???";
            // 
            // bbbvb
            // 
            this.bbbvb.AutoSize = true;
            this.bbbvb.BackColor = System.Drawing.Color.Transparent;
            this.bbbvb.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbbvb.ForeColor = System.Drawing.Color.Teal;
            this.bbbvb.Location = new System.Drawing.Point(12, 622);
            this.bbbvb.Name = "bbbvb";
            this.bbbvb.Size = new System.Drawing.Size(58, 18);
            this.bbbvb.TabIndex = 50;
            this.bbbvb.Text = "Count:";
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
            this.btnAddUpdate.FillColor = System.Drawing.Color.Teal;
            this.btnAddUpdate.FillColor2 = System.Drawing.Color.Aquamarine;
            this.btnAddUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.btnAddUpdate.ForeColor = System.Drawing.Color.Teal;
            this.btnAddUpdate.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAddUpdate.Image = global::Dental_Clinic_Project.Properties.Resources.doctor_add;
            this.btnAddUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUpdate.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddUpdate.Location = new System.Drawing.Point(666, 160);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.ShadowDecoration.Color = System.Drawing.Color.MediumAquamarine;
            this.btnAddUpdate.Size = new System.Drawing.Size(176, 45);
            this.btnAddUpdate.TabIndex = 49;
            this.btnAddUpdate.Text = "Add Dentist";
            this.btnAddUpdate.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Project.Properties.Resources.Dentist_repairing_tooth_decay;
            this.pictureBox1.Location = new System.Drawing.Point(325, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // frmlistDentists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(865, 649);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.bbbvb);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvDent);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlistDentists";
            this.Text = "frmlistDentists";
            this.Load += new System.EventHandler(this.frmlistDentists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDent)).EndInit();
            this.cmsDentists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDent;
        private Guna.UI2.WinForms.Guna2ComboBox cmbfilter;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddUpdate;
        private ReaLTaiizor.Controls.DungeonLabel lblcount;
        private ReaLTaiizor.Controls.DungeonLabel bbbvb;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsDentists;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}