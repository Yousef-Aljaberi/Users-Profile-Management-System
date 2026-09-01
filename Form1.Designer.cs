namespace UsersPorfile_Management_System
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةمستخدمجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمحددToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpInfolist = new System.Windows.Forms.GroupBox();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblSelectedUsers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.gpInfolist.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.عرضToolStripMenuItem,
            this.حولToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1768, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةمستخدمجديدToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(100, 45);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // إضافةمستخدمجديدToolStripMenuItem
            // 
            this.إضافةمستخدمجديدToolStripMenuItem.Name = "إضافةمستخدمجديدToolStripMenuItem";
            this.إضافةمستخدمجديدToolStripMenuItem.Size = new System.Drawing.Size(523, 54);
            this.إضافةمستخدمجديدToolStripMenuItem.Text = "إضافة مستخدم جديد ctr+N";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(523, 54);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // عرضToolStripMenuItem
            // 
            this.عرضToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem,
            this.حذفالمحددToolStripMenuItem});
            this.عرضToolStripMenuItem.Name = "عرضToolStripMenuItem";
            this.عرضToolStripMenuItem.Size = new System.Drawing.Size(110, 45);
            this.عرضToolStripMenuItem.Text = "عرض";
            // 
            // استعراضالبطاقةالتعريفيةToolStripMenuItem
            // 
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.Name = "استعراضالبطاقةالتعريفيةToolStripMenuItem";
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.Size = new System.Drawing.Size(602, 54);
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.Text = "استعراض البطاقة التعريفية ctr+P";
            // 
            // حذفالمحددToolStripMenuItem
            // 
            this.حذفالمحددToolStripMenuItem.Name = "حذفالمحددToolStripMenuItem";
            this.حذفالمحددToolStripMenuItem.Size = new System.Drawing.Size(602, 54);
            this.حذفالمحددToolStripMenuItem.Text = "حذف المحدد";
            // 
            // حولToolStripMenuItem
            // 
            this.حولToolStripMenuItem.Name = "حولToolStripMenuItem";
            this.حولToolStripMenuItem.Size = new System.Drawing.Size(95, 45);
            this.حولToolStripMenuItem.Text = "حول";
            // 
            // gpInfolist
            // 
            this.gpInfolist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpInfolist.Controls.Add(this.lblSelectedUsers);
            this.gpInfolist.Controls.Add(this.lblTotalUsers);
            this.gpInfolist.Location = new System.Drawing.Point(1304, 75);
            this.gpInfolist.Name = "gpInfolist";
            this.gpInfolist.Size = new System.Drawing.Size(452, 400);
            this.gpInfolist.TabIndex = 2;
            this.gpInfolist.TabStop = false;
            this.gpInfolist.Text = "لوحة المعلومات";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalUsers.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(7, 62);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(424, 54);
            this.lblTotalUsers.TabIndex = 0;
            this.lblTotalUsers.Text = "إجمالي عدد المستخدمين:";
            // 
            // lblSelectedUsers
            // 
            this.lblSelectedUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedUsers.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUsers.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedUsers.Location = new System.Drawing.Point(7, 231);
            this.lblSelectedUsers.Name = "lblSelectedUsers";
            this.lblSelectedUsers.Size = new System.Drawing.Size(424, 54);
            this.lblSelectedUsers.TabIndex = 1;
            this.lblSelectedUsers.Text = "المحدد:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1304, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "إضافة مستخدم جديد";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(1304, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(444, 76);
            this.button2.TabIndex = 4;
            this.button2.Text = "استعراض البطاقة";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button3.Location = new System.Drawing.Point(1304, 827);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(444, 76);
            this.button3.TabIndex = 5;
            this.button3.Text = "حذف المحدد";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(121, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 851);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة المستخدمين المسجلين في النظام (انقر نقراً مزدوجاً للعرض";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(28, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1080, 730);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 999);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpInfolist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpInfolist.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةمستخدمجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem استعراضالبطاقةالتعريفيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالمحددToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حولToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpInfolist;
        private System.Windows.Forms.Label lblSelectedUsers;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

