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
    class UserSvscs : IUserSvs
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";

        public List<User> GetAllUser()
        {
            List<User> ListUser = new List<User>();

            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT * FROM TblUsers";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                User newUser = new User();

                newUser.Id = (int)dr["Id"];
                newUser.Name = dr["Name"].ToString();
                newUser.Username = dr["Username"].ToString();
                newUser.Password = dr["Password"].ToString();
                newUser.Level = dr["Level"].ToString();

                ListUser.Add(newUser);
            }

            return ListUser;
        }

        public void Add(string name, string username, string pass, string level)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblUsers (Name, Username, Password, Level ) values('" + name + "','" + username + "','" + pass + "','" + level + " ')";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "delete from TblUsers where Id = @Id";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

            con.Close();
        }

       

        public void Update(int id, string name, string username, string pass, string level)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "UPDATE TblUsers SET Name = @Name , Username = @Username, Password = @Password, Level = @Level where Id = @Id";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", pass);
            cmd.Parameters.AddWithValue("@Level", level);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
