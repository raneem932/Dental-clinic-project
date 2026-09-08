namespace Dental_Clinic_Project.Dentists
{
    partial class ctrDentistCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox10 = new FontAwesome.Sharp.IconPictureBox();
            this.dungeonLabel9 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrDentistCard1 = new Dental_Clinic_Project.Dentists.ctrDentistCard();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.iconPictureBox6);
            this.groupBox1.Controls.Add(this.iconPictureBox10);
            this.groupBox1.Controls.Add(this.dungeonLabel9);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // iconPictureBox10
            // 
            this.iconPictureBox10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox10.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox10.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox10.IconSize = 24;
            this.iconPictureBox10.Location = new System.Drawing.Point(83, 22);
            this.iconPictureBox10.Name = "iconPictureBox10";
            this.iconPictureBox10.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox10.TabIndex = 101;
            this.iconPictureBox10.TabStop = false;
            // 
            // dungeonLabel9
            // 
            this.dungeonLabel9.AutoSize = true;
            this.dungeonLabel9.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel9.ForeColor = System.Drawing.Color.SteelBlue;
            this.dungeonLabel9.Location = new System.Drawing.Point(6, 27);
            this.dungeonLabel9.Name = "dungeonLabel9";
            this.dungeonLabel9.Size = new System.Drawing.Size(77, 17);
            this.dungeonLabel9.TabIndex = 100;
            this.dungeonLabel9.Text = "Dentist ID :";
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
            this.txtFilter.Location = new System.Drawing.Point(113, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(81, 33);
            this.txtFilter.TabIndex = 102;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilter_Validating);
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 24;
            this.iconPictureBox6.Location = new System.Drawing.Point(200, 20);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox6.TabIndex = 97;
            this.iconPictureBox6.TabStop = false;
            this.iconPictureBox6.Click += new System.EventHandler(this.iconPictureBox6_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(230, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 98;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrDentistCard1
            // 
            this.ctrDentistCard1.Location = new System.Drawing.Point(0, 72);
            this.ctrDentistCard1.Name = "ctrDentistCard1";
            this.ctrDentistCard1.Size = new System.Drawing.Size(753, 299);
            this.ctrDentistCard1.TabIndex = 0;
            // 
            // ctrDentistCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrDentistCard1);
            this.Name = "ctrDentistCardWithFilter";
            this.Size = new System.Drawing.Size(749, 372);
            this.Load += new System.EventHandler(this.ctrDentistCardWithFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrDentistCard ctrDentistCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox10;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
