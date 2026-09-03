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
    public partial class frmAddNewUserProfile : Form
    {
        public frmAddNewUserProfile()
        {
            InitializeComponent();
        }
        private void btnSaveAndAddToFile_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("ادخل المعرف ID");
                txtID.Focus();
                return;
            }
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("ادخل الاسم الكامل");
                txtFullName.Focus();
                return;
            }
            if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show(" ادخل التخصص");
                txtDepartment.Focus();
                return;
            }
            if (txtPhoneNumber.Text.Trim() == "ادخل رقم الهاتف")
            {
                MessageBox.Show("");
                txtPhoneNumber.Focus();
                return;
            }
            CreatedProfile = new UserProfile();
            CreatedProfile.ID= txtID.Text.Trim();
            CreatedProfile.FullName= txtFullName.Text.Trim();  
            CreatedProfile.Deparment= txtDepartment.Text.Trim();
            CreatedProfile.PhoneNumber = txtPhoneNumber.Text.Trim();
            CreatedProfile.image = picLoginPhoto.Image;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public UserProfile CreatedProfile { get; private set; }

        private void btnBrowsAndSelectPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images|*.jpg;*png;";
            openFileDialog1.Title = "Choose a picture...";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLoginPhoto.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

}
