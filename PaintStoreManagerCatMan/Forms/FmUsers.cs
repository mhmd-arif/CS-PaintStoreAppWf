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

namespace PaintStoreManagerCatMan.Forms
{
    public partial class FmUsers : Form
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        readonly private UserSvscs newItems = new UserSvscs();
        public FmUsers()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (TB_Name.Text != "" || Tb_Usernm.Text != "" || TB_Password.Text != ""  || CB_Level.SelectedIndex > -1)
            {
                newItems.Add(TB_Name.Text, Tb_Usernm.Text, TB_Password.Text,CB_Level.Text);
            }
            else
            {
                MessageBox.Show("Missing Information");
            }

            UpdateDgv();
            ClearAll();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int id = GetId();

            if (TB_Name.Text != "" || Tb_Usernm.Text != "" || TB_Password.Text != "" || CB_Level.SelectedIndex > -1)
            {
                newItems.Update(id,TB_Name.Text, Tb_Usernm.Text, TB_Password.Text, CB_Level.Text);
            }
            else
            {
                MessageBox.Show("Missing Information");
            }
            

            UpdateDgv();
            ClearAll();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DGV_Users.CurrentRow.Cells[0].Value.ToString());
            newItems.Delete(id);

            UpdateDgv();
            ClearAll();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }



        private int GetId()
        {
            return int.Parse(DGV_Users.CurrentRow.Cells[0].Value.ToString());
        }
        private void ClearAll()
        {
            TB_Name.Clear();
            Tb_Usernm.Clear();
            TB_Password.Clear();


        }
        public void UpdateDgv()
        {
            ClearAll();
            List<User> dgv = newItems.GetAllUser();
            DGV_Users.DataSource = dgv;
        }

        private void FmUsers_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void TB_SearchCate_TextChange(object sender, EventArgs e)
        {

        }

        private void TB_SearchUser_TextChange(object sender, EventArgs e)
        {
            if (TB_SearchUser.Text == "")
            {
                UpdateDgv();
            }
            else
            {
                SqlConnection con = new SqlConnection(connstring);
                string sqlQuery = "SELECT * FROM TblUsers where User = '" + TB_SearchUser.Text + "' ";

                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                DGV_Users.DataSource = dt;
                con.Close();
            }
            
        }

        private void DGV_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Name.Text = DGV_Users.SelectedRows[0].Cells[1].Value.ToString();
            Tb_Usernm.Text = DGV_Users.SelectedRows[0].Cells[2].Value.ToString();
            TB_Password.Text = DGV_Users.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
