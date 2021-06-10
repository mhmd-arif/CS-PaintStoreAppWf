using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintStoreManagerCatMan.Forms
{
    public partial class FmMainAdmin : Form
    {
        //fields
        private Form activeForm;

        public FmMainAdmin()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Lbl_Title.Text = childForm.Text;
        }

        private void Btn_Products_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FmProducts(), sender);
        }

        private void Btn_Categories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FmCategories(), sender);
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FmUsers(), sender);
        }

        private void Btn_Cart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FmCart(), sender);
        }

        private void Btn_Reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FmReports(), sender);
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FmLogin Login = new FmLogin();
                Login.Show();
                this.Hide();
            }
        }


    }
}
