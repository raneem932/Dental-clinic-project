namespace Dental_Clinic_Project.invoices
{
    partial class FrmListInvoces
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvinvoiceslist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblcount = new ReaLTaiizor.Controls.DungeonLabel();
            this.bbbvb = new ReaLTaiizor.Controls.DungeonLabel();
            this.dtpInvoice = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbdateFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoiceslist)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Project.Properties.Resources.istockphoto_2167936216_1024x10241;
            this.pictureBox1.Location = new System.Drawing.Point(318, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // dgvinvoiceslist
            // 
            this.dgvinvoiceslist.AllowUserToAddRows = false;
            this.dgvinvoiceslist.AllowUserToDeleteRows = false;
            this.dgvinvoiceslist.AllowUserToResizeColumns = false;
            this.dgvinvoiceslist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvinvoiceslist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinvoiceslist.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvinvoiceslist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinvoiceslist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinvoiceslist.ColumnHeadersHeight = 35;
            this.dgvinvoiceslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvinvoiceslist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvinvoiceslist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvinvoiceslist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvinvoiceslist.Location = new System.Drawing.Point(12, 190);
            this.dgvinvoiceslist.Name = "dgvinvoiceslist";
            this.dgvinvoiceslist.ReadOnly = true;
            this.dgvinvoiceslist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinvoiceslist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvinvoiceslist.RowHeadersVisible = false;
            this.dgvinvoiceslist.RowTemplate.ReadOnly = true;
            this.dgvinvoiceslist.Size = new System.Drawing.Size(834, 373);
            this.dgvinvoiceslist.TabIndex = 57;
            this.dgvinvoiceslist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvinvoiceslist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvinvoiceslist.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvinvoiceslist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvinvoiceslist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvinvoiceslist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvinvoiceslist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvinvoiceslist.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvinvoiceslist.ThemeStyle.ReadOnly = true;
            this.dgvinvoiceslist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvinvoiceslist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvinvoiceslist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvinvoiceslist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvinvoiceslist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblcount.Location = new System.Drawing.Point(80, 570);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(26, 18);
            this.lblcount.TabIndex = 61;
            this.lblcount.Text = "???";
            // 
            // bbbvb
            // 
            this.bbbvb.AutoSize = true;
            this.bbbvb.BackColor = System.Drawing.Color.Transparent;
            this.bbbvb.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbbvb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bbbvb.Location = new System.Drawing.Point(25, 570);
            this.bbbvb.Name = "bbbvb";
            this.bbbvb.Size = new System.Drawing.Size(58, 18);
            this.bbbvb.TabIndex = 60;
            this.bbbvb.Text = "Count:";
            // 
            // dtpInvoice
            // 
            this.dtpInvoice.Animated = true;
            this.dtpInvoice.BackColor = System.Drawing.Color.Transparent;
            this.dtpInvoice.BorderRadius = 20;
            this.dtpInvoice.Checked = true;
            this.dtpInvoice.FillColor = System.Drawing.Color.RoyalBlue;
            this.dtpInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpInvoice.Location = new System.Drawing.Point(427, 148);
            this.dtpInvoice.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpInvoice.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpInvoice.Name = "dtpInvoice";
            this.dtpInvoice.ShadowDecoration.BorderRadius = 20;
            this.dtpInvoice.ShadowDecoration.Color = System.Drawing.Color.LightBlue;
            this.dtpInvoice.ShadowDecoration.Enabled = true;
            this.dtpInvoice.Size = new System.Drawing.Size(200, 36);
            this.dtpInvoice.TabIndex = 70;
            this.dtpInvoice.Value = new System.DateTime(2026, 8, 26, 19, 57, 18, 86);
            this.dtpInvoice.ValueChanged += new System.EventHandler(this.dtpInvoice_ValueChanged);
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
            this.cmbdateFilter.Location = new System.Drawing.Point(256, 148);
            this.cmbdateFilter.Name = "cmbdateFilter";
            this.cmbdateFilter.Size = new System.Drawing.Size(165, 36);
            this.cmbdateFilter.TabIndex = 69;
            this.cmbdateFilter.SelectedIndexChanged += new System.EventHandler(this.cmbdateFilter_SelectedIndexChanged);
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dungeonLabel1.Location = new System.Drawing.Point(10, 157);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(67, 18);
            this.dungeonLabel1.TabIndex = 68;
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
            this.txtFilter.Location = new System.Drawing.Point(256, 148);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(165, 36);
            this.txtFilter.TabIndex = 67;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
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
            "invoice ID",
            "Patient Name",
            "Dentist Name",
            "invoice Date"});
            this.cmbfilter.Location = new System.Drawing.Point(83, 148);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(167, 36);
            this.cmbfilter.TabIndex = 66;
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
            // 
            // FrmListInvoces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(858, 637);
            this.Controls.Add(this.dtpInvoice);
            this.Controls.Add(this.cmbdateFilter);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.bbbvb);
            this.Controls.Add(this.dgvinvoiceslist);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListInvoces";
            this.Text = "v [\'\' ";
            this.Load += new System.EventHandler(this.FrmListInvoces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoiceslist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvinvoiceslist;
        private ReaLTaiizor.Controls.DungeonLabel lblcount;
        private ReaLTaiizor.Controls.DungeonLabel bbbvb;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpInvoice;
        private Guna.UI2.WinForms.Guna2ComboBox cmbdateFilter;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbfilter;
    }
}