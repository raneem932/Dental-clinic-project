namespace Dental_Clinic_Project.Appointments
{
    partial class FrmAppointmentCard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dental_Clinic_Project.Properties.Resources.istockphoto_2160600453_1024x10241;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Dental_Clinic_Project.Properties.Resources.istockphoto_2160600453_1024x1024;
            this.pictureBox1.Location = new System.Drawing.Point(194, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // foreverGroupBox1
            // 
            this.foreverGroupBox1.ArrowColorF = System.Drawing.Color.SteelBlue;
            this.foreverGroupBox1.ArrowColorH = System.Drawing.Color.RoyalBlue;
            this.foreverGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.foreverGroupBox1.BaseColor = System.Drawing.Color.LightSteelBlue;
            this.foreverGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foreverGroupBox1.Location = new System.Drawing.Point(-1, 183);
            this.foreverGroupBox1.Name = "foreverGroupBox1";
            this.foreverGroupBox1.ShowArrow = true;
            this.foreverGroupBox1.ShowText = true;
            this.foreverGroupBox1.Size = new System.Drawing.Size(682, 270);
            this.foreverGroupBox1.TabIndex = 1;
            this.foreverGroupBox1.Text = "Appointment Card";
            this.foreverGroupBox1.TextColor = System.Drawing.Color.Blue;
            // 
            // FrmAppointmentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.foreverGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAppointmentCard";
            this.Text = "FrmAppointmentCard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
    }
}