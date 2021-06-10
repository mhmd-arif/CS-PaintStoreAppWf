using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;
using PaintStoreManagerCatMan.Service;
using System.Data.SqlClient;


namespace PaintStoreManagerCatMan.Service
{
    class PaintSvs : IPaintSvs
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Paints> GetAllPaints()
        {
            List<Paints> ListPaints = new List<Paints>();

            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT * FROM TblPaints";

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

            return ListPaints;
        }

        public void Add(string nama, string color, string ctg, string size, int qty, double bp, double sp)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblPaints (Category,Brand,Color,Size,Quantity,BuyPrice,SellPrice) values('" + nama + "','" + color + "','" + ctg + "','" + size + "','" + qty + "','" + bp + "','" + sp + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "delete from Tblpaints where Id = @Id";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Update(int id, string nama, string color, string ctg, string size, int qty, double bp, double sp)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "UPDATE TblPaints SET Brand = @Brand , Color = @Color,Category = @Category, Size = @Size , Quantity = @Quantity , BuyPrice = @BuyPrice, SellPrice = @SellPrice where Id = @Id";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Brand", nama);
            cmd.Parameters.AddWithValue("@Category", ctg);
            cmd.Parameters.AddWithValue("@Color", color);
            cmd.Parameters.AddWithValue("@Size", size);
            cmd.Parameters.AddWithValue("@Quantity", qty);
            cmd.Parameters.AddWithValue("@BuyPrice", bp);
            cmd.Parameters.AddWithValue("@SellPrice", sp);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        
    }
}
