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
    class CategoryServices : ICategorySvs
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Category> GetAllCategories()
        {
            List<Category> ListCate = new List<Category>();

            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT * FROM TblCategories";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Category newCate = new Category();

                newCate.Id = (int)dr["Id"];
                newCate.CateName = dr["CateName"].ToString();
                newCate.CateDesc = dr["CateDesc"].ToString();

                ListCate.Add(newCate);
            }

            return ListCate;
        }

        public void Add(string catname, string catdesc)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblCategories (Catename, CateDesc) values('" + catname + "','" + catdesc + "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "delete from TblCategories where Id = @Id";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            
            con.Close();
        }

        public void Update(int id, string catname, string catdesc)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "UPDATE TblCategories SET CateName = @CateName, CateDesc = @CateDesc where Id = @Id";
            
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CateName", catname);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@CateDesc", catdesc);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
