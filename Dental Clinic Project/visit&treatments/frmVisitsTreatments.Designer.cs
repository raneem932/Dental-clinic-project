namespace Dental_Clinic_Project.visit_treatments
{
    partial class frmVisitsTreatments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitsTreatments));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.dgvVisitstreatments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblcount = new ReaLTaiizor.Controls.DungeonLabel();
            this.bbbvb = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.cmbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbdateFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePacker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitstreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Project.Properties.Resources.Dentist_taking_care_of_teeth_health;
            this.pictureBox1.Location = new System.Drawing.Point(301, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.bigLabel1.Location = new System.Drawing.Point(274, 132);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(255, 36);
            this.bigLabel1.TabIndex = 54;
            this.bigLabel1.Text = "visits&Treatments";
            // 
            // dgvVisitstreatments
            // 
            this.dgvVisitstreatments.AllowUserToAddRows = false;
            this.dgvVisitstreatments.AllowUserToDeleteRows = false;
            this.dgvVisitstreatments.AllowUserToResizeColumns = false;
            this.dgvVisitstreatments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dgvVisitstreatments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitstreatments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVisitstreatments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitstreatments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisitstreatments.ColumnHeadersHeight = 35;
            this.dgvVisitstreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitstreatments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVisitstreatments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVisitstreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.dgvVisitstreatments.Location = new System.Drawing.Point(12, 207);
            this.dgvVisitstreatments.Name = "dgvVisitstreatments";
            this.dgvVisitstreatments.ReadOnly = true;
            this.dgvVisitstreatments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitstreatments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVisitstreatments.RowHeadersVisible = false;
            this.dgvVisitstreatments.RowTemplate.ReadOnly = true;
            this.dgvVisitstreatments.Size = new System.Drawing.Size(825, 395);
            this.dgvVisitstreatments.TabIndex = 56;
            this.dgvVisitstreatments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple;
            this.dgvVisitstreatments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dgvVisitstreatments.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVisitstreatments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.dgvVisitstreatments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.dgvVisitstreatments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvVisitstreatments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVisitstreatments.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvVisitstreatments.ThemeStyle.ReadOnly = true;
            this.dgvVisitstreatments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            this.dgvVisitstreatments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVisitstreatments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVisitstreatments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            this.dgvVisitstreatments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblcount.Location = new System.Drawing.Point(67, 609);
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
            this.bbbvb.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.bbbvb.Location = new System.Drawing.Point(12, 609);
            this.bbbvb.Name = "bbbvb";
            this.bbbvb.Size = new System.Drawing.Size(58, 18);
            this.bbbvb.TabIndex = 60;
            this.bbbvb.Text = "Count:";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.dungeonLabel1.Location = new System.Drawing.Point(9, 174);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(67, 18);
            this.dungeonLabel1.TabIndex = 63;
            this.dungeonLabel1.Text = "Filter By";
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
            "Patient Name",
            "Dentist Name",
            "Visit Date"});
            this.cmbfilter.Location = new System.Drawing.Point(82, 165);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(167, 36);
            this.cmbfilter.TabIndex = 62;
            this.cmbfilter.SelectedIndexChanged += new System.EventHandler(this.cmbfilter_SelectedIndexChanged);
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
            this.txtFilter.Location = new System.Drawing.Point(255, 165);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(165, 36);
            this.txtFilter.TabIndex = 64;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
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
            this.cmbdateFilter.Location = new System.Drawing.Point(255, 165);
            this.cmbdateFilter.Name = "cmbdateFilter";
            this.cmbdateFilter.Size = new System.Drawing.Size(165, 36);
            this.cmbdateFilter.TabIndex = 65;
            this.cmbdateFilter.SelectedIndexChanged += new System.EventHandler(this.cmbdateFilter_SelectedIndexChanged);
            // 
            // dateTimePacker
            // 
            this.dateTimePacker.Animated = true;
            this.dateTimePacker.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePacker.BorderRadius = 20;
            this.dateTimePacker.Checked = true;
            this.dateTimePacker.FillColor = System.Drawing.Color.MediumVioletRed;
            this.dateTimePacker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePacker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePacker.Location = new System.Drawing.Point(426, 165);
            this.dateTimePacker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePacker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePacker.Name = "dateTimePacker";
            this.dateTimePacker.ShadowDecoration.BorderRadius = 20;
            this.dateTimePacker.ShadowDecoration.Color = System.Drawing.Color.Plum;
            this.dateTimePacker.ShadowDecoration.Enabled = true;
            this.dateTimePacker.Size = new System.Drawing.Size(200, 36);
            this.dateTimePacker.TabIndex = 66;
            this.dateTimePacker.Value = new System.DateTime(2026, 8, 26, 19, 57, 18, 86);
            this.dateTimePacker.ValueChanged += new System.EventHandler(this.dateTimePacker_ValueChanged);
            // 
            // frmVisitsTreatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(849, 636);
            this.Controls.Add(this.dateTimePacker);
            this.Controls.Add(this.cmbdateFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.bbbvb);
            this.Controls.Add(this.dgvVisitstreatments);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisitsTreatments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisitsTreatments";
            this.Load += new System.EventHandler(this.frmVisitsTreatments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitstreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVisitstreatments;
        private ReaLTaiizor.Controls.DungeonLabel lblcount;
        private ReaLTaiizor.Controls.DungeonLabel bbbvb;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbfilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbdateFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePacker;
    }
}