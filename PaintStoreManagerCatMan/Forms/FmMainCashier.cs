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
    public partial class FmMainCashier : Form
    {
        //fields
        private Form activeForm;

        public FmMainCashier()
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

        private void Btn_Cart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FmCart(), sender);
        }

        private void Btn_History_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FmReports(), sender);
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout ?","Logout",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FmLogin Login = new FmLogin();
                Login.Show();
                this.Hide();
            }
            
        }
    }
}
