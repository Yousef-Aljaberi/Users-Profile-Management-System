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
    public partial class frmPorfileCard : Form
    {
        public frmPorfileCard()
        {
            InitializeComponent();
        }
        public frmPorfileCard(UserProfile userPfrofile)
        {
            InitializeComponent();
            pictureBox1.Image = userPfrofile.image;
            lblFullName.Text = userPfrofile.FullName;
            lblID.Text = "الرقم التريفي: "+userPfrofile.ID;
            lblDepartment.Text = "القسم-التخصص: " + userPfrofile.Deparment;
            lblPhoneNumber.Text = "رقم الهاتف: " + userPfrofile.PhoneNumber;

        }

        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPorfileCard_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
