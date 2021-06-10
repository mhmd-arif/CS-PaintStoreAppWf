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
    public partial class FmCategories : Form
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        readonly private CategoryServices newCategory = new CategoryServices();

        public FmCategories()
        {
            InitializeComponent();
            UpdateDgv();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (TB_Category.Text != "")
            {
                newCategory.Add(TB_Category.Text, TB_CateDesc.Text);
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
            int id = int.Parse(DGV_Cate.CurrentRow.Cells[0].Value.ToString());
            newCategory.Delete(id);

            UpdateDgv();
            ClearAll();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            int id = GetId();
            newCategory.Update(id, TB_Category.Text, TB_CateDesc.Text);

            UpdateDgv();
            ClearAll();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private int GetId()
        {
            return int.Parse(DGV_Cate.CurrentRow.Cells[0].Value.ToString());
        }
        private void ClearAll()
        {
            TB_Category.Clear();
            TB_CateDesc.Clear();
        }
        public void UpdateDgv()
        {
            List<Category> dgvCate = newCategory.GetAllCategories();
            DGV_Cate.DataSource = dgvCate;
        }

        private void FmCategories_Load(object sender, EventArgs e)
        {
            ClearAll();
            UpdateDgv();
        }

        private void DGV_Cate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_Category.Text = DGV_Cate.SelectedRows[0].Cells[1].Value.ToString();
            TB_CateDesc.Text = DGV_Cate.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void TB_SearchCate_TextChange(object sender, EventArgs e)
        {
            if (TB_SearchCate.Text == "")
            {
                UpdateDgv();
            }
            else
            {
                SqlConnection con = new SqlConnection(connstring);
                string sqlQuery = "SELECT * FROM TblCategories where CateName = '" + TB_SearchCate.Text + "' ";

                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                DGV_Cate.DataSource = dt;
                con.Close();
            }
        }
    }
}
