using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintStoreManagerCatMan.Entity;
using PaintStoreManagerCatMan.Service;
using System.Data.SqlClient;

namespace PaintStoreManagerCatMan.Forms
{
    public partial class FmCart : Form
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        readonly private PaintSvs newPaint = new PaintSvs();
        readonly private CartSvs newCart = new CartSvs();
        readonly private ReportsSvs newReport = new ReportsSvs();

        double totalTrans = 0;
        double BuyerMoney;

        public FmCart()
        {
            InitializeComponent();
        }

        private void Btn_Pay_Click(object sender, EventArgs e)
        {
            double buyerMoney = double.Parse(Tb_CustomerCash.Text);
            double totalCost = double.Parse(Lbl_Total.Text);
            double change = buyerMoney - totalCost;

            if (BuyerMoney < 0)
            {
                MessageBox.Show("input incorrect, please try again");
            }
            else
            {
                if (buyerMoney < totalCost)
                {
                    MessageBox.Show("Not Enough Money !, please try again");
                }
                else
                {
                    string date = DateTime.Now.ToString();
                    newReport.Add(TB_CustomerName.Text, "CASHIER", buyerMoney,totalCost, change, date);
                    MessageBox.Show("Transaction Success");
                }

            }
/*
            try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input");
            }*/
        }

        private void Btn_AddCart_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(DGV_PaintCart.CurrentRow.Cells[0].Value.ToString());

            string _Brand = "";
            string _Color = "";
            string _category = "";
            string _size = "";
            double _Price = 0;

            string sql = "select * from TblPaints where Id = '" + id + "' ";
            
            SqlConnection con = new SqlConnection(connstring);

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _Brand = dr[1].ToString();
                _Color = dr[2].ToString();
                _category = dr[3].ToString();
                _size = dr[4].ToString();
                _Price = double.Parse(dr[7].ToString());
            }
            con.Close();
            
            newCart.Add(_Brand, _Color,_category, _size, _Price);

            double total = double.Parse(DGV_PaintCart.CurrentRow.Cells[6].Value.ToString());
            totalTrans = totalTrans + total;
            UpdateDgv();
        }

        private void FillCombo()
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT CateName, Id FROM TblCategories";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_CateCart.Items.Add(dr["CateName"].ToString());
                CB_CateCart.DisplayMember = dr["CateName"].ToString();
                CB_CateCart.ValueMember = dr["Id"].ToString();
            }
            con.Close();
        }

        private void FmCart_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            FillCombo();
        }
        
        private void ClearAll()
        {
            TB_CustomerName.Clear();
            Tb_CustomerCash.Clear();
        }
        public void UpdateDgv()
        { 

            DGV_PaintCart.AutoGenerateColumns = false;
            List<Paints> dgv = newPaint.GetAllPaints();
            DGV_PaintCart.DataSource = dgv;

            DGV_Cart.AutoGenerateColumns = false;
            List<Carts> dgvCart = newCart.GetAllCarts();
            DGV_Cart.DataSource = dgvCart;

            Lbl_Total.Text = totalTrans.ToString();

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_CateCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_CateCart.Text == "All")
            {
                UpdateDgv();
            }
            else
            {
                List<Paints> ListPaints = new List<Paints>();

                SqlConnection con = new SqlConnection(connstring);
                string sql = "SELECT * FROM TblPaints where Category = '" + CB_CateCart.Text + "'";

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Paints newPaints = new Paints();

                    newPaints.Id = (int)dr["Id"];
                    newPaints.Brand = dr["Brand"].ToString();
                    newPaints.Color = dr["Color"].ToString();
                    newPaints.Category = dr["Category"].ToString();
                    newPaints.Size = dr["Size"].ToString();
                    newPaints.Quantity = (int)dr["Quantity"];
                    newPaints.BuyPrice = (double)dr["BuyPrice"];
                    newPaints.SellPrice = (double)dr["SellPrice"];

                    ListPaints.Add(newPaints);
                }

                List<Paints> dgv = ListPaints;
                DGV_PaintCart.DataSource = dgv;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Btn_DeleteCart_Click(object sender, EventArgs e)
        { 
            int id = int.Parse(DGV_Cart.CurrentRow.Cells[0].Value.ToString());

            newCart.Delete(id);

            double total = double.Parse(DGV_Cart.CurrentRow.Cells[5].Value.ToString());
            totalTrans = totalTrans - total;
            UpdateDgv();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void TB_SearchByBrand_TextChange(object sender, EventArgs e)
        {
            if (TB_SearchByBrand.Text == "")
            {
                UpdateDgv();
            }
            else
            {
                SqlConnection con = new SqlConnection(connstring);
                string sqlQuery = "SELECT * FROM TblPaints where Brand = '" + TB_SearchByBrand.Text + "' ";

                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                DGV_PaintCart.DataSource = dt;
                con.Close();
            }
           
        }

        private void TB_SearchByColor_TextChange(object sender, EventArgs e)
        {
            if (TB_SearchByColor.Text == "")
            {
                UpdateDgv();
            }
            else
            {
                SqlConnection con = new SqlConnection(connstring);
                string sqlQuery = "SELECT * FROM TblPaints where Color = '" + TB_SearchByColor.Text + "' ";

                con.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                DGV_PaintCart.DataSource = dt;
                con.Close();
            }
            
        }

        private void Tb_CustomerCash_TextChange(object sender, EventArgs e)
        {
            
        }
    }
}
