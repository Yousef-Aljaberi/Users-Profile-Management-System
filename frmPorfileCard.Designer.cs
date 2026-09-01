namespace UsersPorfile_Management_System
{
    partial class frmPorfileCard
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCloseCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(274, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 449);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFullName.Location = new System.Drawing.Point(349, 666);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(357, 51);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "label1";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblID.Location = new System.Drawing.Point(349, 737);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(357, 51);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label2";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartment
            // 
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDepartment.Location = new System.Drawing.Point(349, 837);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(357, 51);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "label3";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(349, 915);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(357, 51);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "label4";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(62, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1108, 129);
            this.label5.TabIndex = 5;
            this.label5.Text = "بطاقة الملف الشخصي(Profile Card)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseCard
            // 
            this.btnCloseCard.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseCard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseCard.Location = new System.Drawing.Point(338, 980);
            this.btnCloseCard.Name = "btnCloseCard";
            this.btnCloseCard.Size = new System.Drawing.Size(352, 73);
            this.btnCloseCard.TabIndex = 6;
            this.btnCloseCard.Text = "إغلاق البطاقة";
            this.btnCloseCard.UseVisualStyleBackColor = false;
            // 
            // frmPorfileCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 1091);
            this.Controls.Add(this.btnCloseCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPorfileCard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmPorfileCard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCloseCard;
    }
}