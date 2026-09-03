namespace UsersPorfile_Management_System
{
    partial class frmAddNewUserProfile
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowsAndSelectPhoto = new System.Windows.Forms.Button();
            this.picLoginPhoto = new System.Windows.Forms.PictureBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAndAddToFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnBrowsAndSelectPhoto);
            this.groupBox1.Controls.Add(this.picLoginPhoto);
            this.groupBox1.Location = new System.Drawing.Point(960, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 651);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصورة الشخصية";
            // 
            // btnBrowsAndSelectPhoto
            // 
            this.btnBrowsAndSelectPhoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBrowsAndSelectPhoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowsAndSelectPhoto.Location = new System.Drawing.Point(116, 506);
            this.btnBrowsAndSelectPhoto.Name = "btnBrowsAndSelectPhoto";
            this.btnBrowsAndSelectPhoto.Size = new System.Drawing.Size(459, 92);
            this.btnBrowsAndSelectPhoto.TabIndex = 1;
            this.btnBrowsAndSelectPhoto.Text = "تصفح واختيار صورة...";
            this.btnBrowsAndSelectPhoto.UseVisualStyleBackColor = false;
            this.btnBrowsAndSelectPhoto.Click += new System.EventHandler(this.btnBrowsAndSelectPhoto_Click);
            // 
            // picLoginPhoto
            // 
            this.picLoginPhoto.Location = new System.Drawing.Point(59, 60);
            this.picLoginPhoto.Name = "picLoginPhoto";
            this.picLoginPhoto.Size = new System.Drawing.Size(530, 422);
            this.picLoginPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginPhoto.TabIndex = 0;
            this.picLoginPhoto.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancle.Location = new System.Drawing.Point(960, 818);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(603, 92);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "إلغاء";
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDepartment);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(43, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 651);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " البيانات الأساسية للمستخدم";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(60, 502);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(756, 72);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(439, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = "رقم الهاتف:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(60, 370);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(756, 72);
            this.txtDepartment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(452, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "القسم /التخصص:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(60, 237);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(756, 72);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(452, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "الإسم الكامل:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(60, 105);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(756, 72);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(452, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقم الأكاديمي / الوظيفي:";
            // 
            // btnSaveAndAddToFile
            // 
            this.btnSaveAndAddToFile.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveAndAddToFile.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndAddToFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveAndAddToFile.Location = new System.Drawing.Point(54, 818);
            this.btnSaveAndAddToFile.Name = "btnSaveAndAddToFile";
            this.btnSaveAndAddToFile.Size = new System.Drawing.Size(870, 92);
            this.btnSaveAndAddToFile.TabIndex = 4;
            this.btnSaveAndAddToFile.Text = "حفظ وإضافة الملف";
            this.btnSaveAndAddToFile.UseVisualStyleBackColor = false;
            this.btnSaveAndAddToFile.Click += new System.EventHandler(this.btnSaveAndAddToFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmAddNewUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1581, 1005);
            this.Controls.Add(this.btnSaveAndAddToFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddNewUserProfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmAddNewUserProfile";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowsAndSelectPhoto;
        private System.Windows.Forms.PictureBox picLoginPhoto;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAndAddToFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}