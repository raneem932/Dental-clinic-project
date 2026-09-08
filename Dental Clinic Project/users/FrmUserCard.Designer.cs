namespace Dental_Clinic_Project.users
{
    partial class UserCard
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
            this.icnSave = new ReaLTaiizor.Controls.TickIcon();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblName = new ReaLTaiizor.Controls.BigLabel();
            this.uctrUserCard1 = new Dental_Clinic_Project.users.UctrUserCard();
            this.SuspendLayout();
            // 
            // icnSave
            // 
            this.icnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.icnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.icnSave.CircleColor = System.Drawing.Color.Gray;
            this.icnSave.Font = new System.Drawing.Font("Wingdings", 25F, System.Drawing.FontStyle.Bold);
            this.icnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.icnSave.Location = new System.Drawing.Point(501, 362);
            this.icnSave.Name = "icnSave";
            this.icnSave.Size = new System.Drawing.Size(33, 33);
            this.icnSave.String = "ü";
            this.icnSave.TabIndex = 136;
            this.icnSave.Text = "tickIcon1";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderRadius = 14;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(498, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 135;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName.Location = new System.Drawing.Point(214, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 37);
            this.lblName.TabIndex = 117;
            this.lblName.Text = "User Card";
            // 
            // uctrUserCard1
            // 
            this.uctrUserCard1.Location = new System.Drawing.Point(12, 78);
            this.uctrUserCard1.Name = "uctrUserCard1";
            this.uctrUserCard1.Size = new System.Drawing.Size(494, 291);
            this.uctrUserCard1.TabIndex = 137;
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 403);
            this.Controls.Add(this.uctrUserCard1);
            this.Controls.Add(this.icnSave);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserCard";
            this.Load += new System.EventHandler(this.UserCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.TickIcon icnSave;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private ReaLTaiizor.Controls.BigLabel lblName;
        private UctrUserCard uctrUserCard1;
    }
}