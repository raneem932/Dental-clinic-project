namespace Dental_Clinic_Project.patients
{
    partial class ctrPatientCardWithFilter
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
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.dungeonLabel9 = new ReaLTaiizor.Controls.DungeonLabel();
            this.uctPatient1 = new Dental_Clinic_Project.patients.UctPatient();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewPerson);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.dungeonLabel9);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackgroundImage = global::Dental_Clinic_Project.Properties.Resources.patient1;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewPerson.Location = new System.Drawing.Point(274, 20);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(38, 31);
            this.btnAddNewPerson.TabIndex = 79;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::Dental_Clinic_Project.Properties.Resources.patient__1_;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(229, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(38, 31);
            this.btnFind.TabIndex = 78;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.txtFilter.Location = new System.Drawing.Point(88, 25);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(135, 26);
            this.txtFilter.TabIndex = 72;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilter_Validating);
            // 
            // dungeonLabel9
            // 
            this.dungeonLabel9.AutoSize = true;
            this.dungeonLabel9.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dungeonLabel9.Location = new System.Drawing.Point(6, 34);
            this.dungeonLabel9.Name = "dungeonLabel9";
            this.dungeonLabel9.Size = new System.Drawing.Size(76, 17);
            this.dungeonLabel9.TabIndex = 71;
            this.dungeonLabel9.Text = "Patient ID :";
            // 
            // uctPatient1
            // 
            this.uctPatient1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uctPatient1.Location = new System.Drawing.Point(0, 103);
            this.uctPatient1.Name = "uctPatient1";
            this.uctPatient1.Size = new System.Drawing.Size(642, 294);
            this.uctPatient1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrPatientCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uctPatient1);
            this.Name = "ctrPatientCardWithFilter";
            this.Size = new System.Drawing.Size(642, 400);
            this.Load += new System.EventHandler(this.ctrPatientCardWithFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UctPatient uctPatient1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
