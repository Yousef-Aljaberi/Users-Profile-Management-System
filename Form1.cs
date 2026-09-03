using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersPorfile_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        List<UserProfile> userList = new List<UserProfile>();
        private void btnAddFileUser_Click(object sender, EventArgs e)
        {
            frmAddNewUserProfile addform = new frmAddNewUserProfile();
            if(addform.ShowDialog()==DialogResult.OK)
            {
                UserProfile newUser = addform.CreatedProfile;
                userList.Add(newUser);
                lstUsers.Items.Add(newUser);

            }
            lblTotalUsers.Text += "إجمالي عدد المستخدمين: " + lstUsers.Items.Count.ToString();


        }

        private void btnShowCard_Click(object sender, EventArgs e)
        {
            frmPorfileCard frmPorfileCard=new frmPorfileCard((UserProfile)lstUsers.SelectedItem);
            frmPorfileCard.ShowDialog();

        }

        private void lstUsers_DoubleClick(object sender, EventArgs e)
        {
            frmPorfileCard frmPorfileCard = new frmPorfileCard((UserProfile)lstUsers.SelectedItem);
            frmPorfileCard.ShowDialog();
        }

      

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedUsers.Text = "المحدد: " + lstUsers.SelectedItems.Count.ToString();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Remove(lstUsers.SelectedItem);
            lblTotalUsers.Text = "إجمالي عدد المستخدمين: " + lstUsers.Items.Count.ToString();
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFileUser_Click(sender,  e);
        }

        private void استعراضالبطاقةالتعريفيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnShowCard_Click(sender,e);
        }

        private void حذفالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteSelected_Click(sender,e);
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}


