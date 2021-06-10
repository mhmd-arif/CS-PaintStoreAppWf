using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintStoreManagerCatMan.Service;
using System.Data.SqlClient;
using PaintStoreManagerCatMan.Entity;

using System.Windows.Forms;

namespace PaintStoreManagerCatMan.Forms
{
    
    public partial class FmLogin : Form
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        public FmLogin()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (TB_Username.Text == "" || TB_Password.Text == "")
            {
                MessageBox.Show("Enter The Username and Password");
            }
            else
            {
                if(CB_Role.SelectedIndex > -1)
                {
                    if(CB_Role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (TB_Username.Text == "ADMIN" && TB_Password.Text == "ADMIN" )
                        {
                            FmMainAdmin mainAdminFm = new FmMainAdmin();
                            mainAdminFm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorect Username or Password");
                        }
                    }
                    else if(CB_Role.SelectedItem.ToString() == "CASHIER")
                    {
                        if (TB_Username.Text == "CASHIER" && TB_Password.Text == "CASHIER")
                        {
                            FmMainCashier mainCashierFm = new FmMainCashier();
                            mainCashierFm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorect Username or Password");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TB_Username.Clear();
            TB_Password.Clear();
            CB_Role.SelectedItem = "Select a Role";
        }

        private void FillCombo()
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT Username, Id FROM TblUsers";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_Role.Items.Add(dr["Username"].ToString());
                CB_Role.DisplayMember = dr["Username"].ToString();
                CB_Role.ValueMember = dr["Id"].ToString();
            }
            con.Close();
        }
    }
}
