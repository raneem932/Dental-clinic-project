namespace Dental_Clinic_Project.patients
{
    partial class frmShowInfoPatient
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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.icnSave = new ReaLTaiizor.Controls.TickIcon();
            this.uctPatient1 = new Dental_Clinic_Project.patients.UctPatient();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 24;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.LightSkyBlue;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 80;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DarkCyan;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // icnSave
            // 
            this.icnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.icnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.icnSave.CircleColor = System.Drawing.Color.Gray;
            this.icnSave.Font = new System.Drawing.Font("Wingdings", 25F, System.Drawing.FontStyle.Bold);
            this.icnSave.ForeColor = System.Drawing.Color.Teal;
            this.icnSave.Location = new System.Drawing.Point(578, 244);
            this.icnSave.Name = "icnSave";
            this.icnSave.Size = new System.Drawing.Size(33, 33);
            this.icnSave.String = "ü";
            this.icnSave.TabIndex = 50;
            this.icnSave.Text = "tickIcon1";
            this.icnSave.Click += new System.EventHandler(this.icnSave_Click);
            // 
            // uctPatient1
            // 
            this.uctPatient1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uctPatient1.Location = new System.Drawing.Point(-4, -5);
            this.uctPatient1.Name = "uctPatient1";
            this.uctPatient1.Size = new System.Drawing.Size(650, 298);
            this.uctPatient1.TabIndex = 2;
            this.uctPatient1.Load += new System.EventHandler(this.uctPatient1_Load);
            // 
            // frmShowInfoPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(635, 289);
            this.Controls.Add(this.icnSave);
            this.Controls.Add(this.uctPatient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowInfoPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowInfoPatient";
            this.Load += new System.EventHandler(this.ShowInfoPatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private UctPatient uctPatient1;
        private ReaLTaiizor.Controls.TickIcon icnSave;
    }
}