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
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnShowCard = new System.Windows.Forms.Button();
            this.btnAddFileUser = new System.Windows.Forms.Button();
            this.lblSelectedUsers = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.gpInfolist.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.عرضToolStripMenuItem,
            this.حولToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(2070, 114);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةمستخدمجديدToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(100, 110);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // إضافةمستخدمجديدToolStripMenuItem
            // 
            this.إضافةمستخدمجديدToolStripMenuItem.Name = "إضافةمستخدمجديدToolStripMenuItem";
            this.إضافةمستخدمجديدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.إضافةمستخدمجديدToolStripMenuItem.Size = new System.Drawing.Size(553, 54);
            this.إضافةمستخدمجديدToolStripMenuItem.Text = "إضافة مستخدم جديد ";
            this.إضافةمستخدمجديدToolStripMenuItem.Click += new System.EventHandler(this.إضافةمستخدمجديدToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(553, 54);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // عرضToolStripMenuItem
            // 
            this.عرضToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem,
            this.حذفالمحددToolStripMenuItem});
            this.عرضToolStripMenuItem.Name = "عرضToolStripMenuItem";
            this.عرضToolStripMenuItem.Size = new System.Drawing.Size(110, 110);
            this.عرضToolStripMenuItem.Text = "عرض";
            // 
            // استعراضالبطاقةالتعريفيةToolStripMenuItem
            // 
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.Name = "استعراضالبطاقةالتعريفيةToolStripMenuItem";
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.Size = new System.Drawing.Size(632, 54);
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.Text = "استعراض البطاقة التعريفية ";
            this.استعراضالبطاقةالتعريفيةToolStripMenuItem.Click += new System.EventHandler(this.استعراضالبطاقةالتعريفيةToolStripMenuItem_Click);
            // 
            // حذفالمحددToolStripMenuItem
            // 
            this.حذفالمحددToolStripMenuItem.Name = "حذفالمحددToolStripMenuItem";
            this.حذفالمحددToolStripMenuItem.Size = new System.Drawing.Size(632, 54);
            this.حذفالمحددToolStripMenuItem.Text = "حذف المحدد";
            this.حذفالمحددToolStripMenuItem.Click += new System.EventHandler(this.حذفالمحددToolStripMenuItem_Click);
            // 
            // حولToolStripMenuItem
            // 
            this.حولToolStripMenuItem.Name = "حولToolStripMenuItem";
            this.حولToolStripMenuItem.Size = new System.Drawing.Size(95, 110);
            this.حولToolStripMenuItem.Text = "حول";
            // 
            // gpInfolist
            // 
            this.gpInfolist.AutoSize = true;
            this.gpInfolist.BackColor = System.Drawing.SystemColors.Control;
            this.gpInfolist.Controls.Add(this.btnDeleteSelected);
            this.gpInfolist.Controls.Add(this.btnShowCard);
            this.gpInfolist.Controls.Add(this.btnAddFileUser);
            this.gpInfolist.Controls.Add(this.lblSelectedUsers);
            this.gpInfolist.Controls.Add(this.lblTotalUsers);
            this.gpInfolist.Location = new System.Drawing.Point(1286, 174);
            this.gpInfolist.Name = "gpInfolist";
            this.gpInfolist.Size = new System.Drawing.Size(650, 857);
            this.gpInfolist.TabIndex = 2;
            this.gpInfolist.TabStop = false;
            this.gpInfolist.Text = "لوحة المعلومات";
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteSelected.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDeleteSelected.Location = new System.Drawing.Point(133, 742);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(444, 76);
            this.btnDeleteSelected.TabIndex = 7;
            this.btnDeleteSelected.Text = "حذف المحدد";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnShowCard
            // 
            this.btnShowCard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowCard.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnShowCard.Location = new System.Drawing.Point(133, 603);
            this.btnShowCard.Name = "btnShowCard";
            this.btnShowCard.Size = new System.Drawing.Size(444, 76);
            this.btnShowCard.TabIndex = 6;
            this.btnShowCard.Text = "استعراض البطاقة";
            this.btnShowCard.UseVisualStyleBackColor = false;
            this.btnShowCard.Click += new System.EventHandler(this.btnShowCard_Click);
            // 
            // btnAddFileUser
            // 
            this.btnAddFileUser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddFileUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddFileUser.Location = new System.Drawing.Point(133, 487);
            this.btnAddFileUser.Name = "btnAddFileUser";
            this.btnAddFileUser.Size = new System.Drawing.Size(444, 76);
            this.btnAddFileUser.TabIndex = 4;
            this.btnAddFileUser.Text = "إضافة ملف جديد";
            this.btnAddFileUser.UseVisualStyleBackColor = false;
            this.btnAddFileUser.Click += new System.EventHandler(this.btnAddFileUser_Click);
            // 
            // lblSelectedUsers
            // 
            this.lblSelectedUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedUsers.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUsers.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedUsers.Location = new System.Drawing.Point(186, 271);
            this.lblSelectedUsers.Name = "lblSelectedUsers";
            this.lblSelectedUsers.Size = new System.Drawing.Size(424, 54);
            this.lblSelectedUsers.TabIndex = 1;
            this.lblSelectedUsers.Text = "المحدد:";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalUsers.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(250, 114);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(360, 34);
            this.lblTotalUsers.TabIndex = 0;
            this.lblTotalUsers.Text = "إجمالي عدد المستخدمين:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstUsers);
            this.groupBox1.Location = new System.Drawing.Point(125, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 851);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة المستخدمين المسجلين في النظام (انقر نقراً مزدوجاً للعرض";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 33;
            this.lstUsers.Location = new System.Drawing.Point(34, 75);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstUsers.Size = new System.Drawing.Size(1080, 730);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            this.lstUsers.DoubleClick += new System.EventHandler(this.lstUsers_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2070, 1203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpInfolist);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpInfolist.ResumeLayout(false);
            this.gpInfolist.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnShowCard;
        private System.Windows.Forms.Button btnAddFileUser;
    }
}

