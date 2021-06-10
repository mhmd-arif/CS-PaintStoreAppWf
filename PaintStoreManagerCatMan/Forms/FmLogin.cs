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

        public static string sellerName = "";
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
                    SqlConnection con = new SqlConnection(connstring);
                    string sql = "SELECT COUNT(*) FROM TblUsers WHERE Username = '"+TB_Username.Text+ "' AND Password = '" + TB_Password.Text + "' AND Level = '" + CB_Role.SelectedItem.ToString() + "'";

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (CB_Role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            sellerName = TB_Username.Text;
                            FmMainAdmin mainAdminFm = new FmMainAdmin();
                            mainAdminFm.Show();
                            this.Hide();
                            con.Close();
                        }
                        
                        else
                        {
                            MessageBox.Show("Incorect Username or Password");
                        }
                    }
                    else if (CB_Role.SelectedItem.ToString() == "CASHIER")
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            sellerName = TB_Username.Text;
                            FmMainCashier mainCashierFm = new FmMainCashier();
                            mainCashierFm.Show();
                            this.Hide();
                            con.Close();
                        }
                        
                        else
                        {
                            MessageBox.Show("Incorect Username or Password");
                        }
                    }
                    else
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }

       

        private void CB_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FmLogin_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TB_Username.Clear();
            TB_Password.Clear();
            CB_Role.SelectedItem = "Select a Role";
        }
    }
}
