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
    class ReportsSvs : IReportsSvs
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";

        public void Add(string customer, string cashier, double cash,double trans, double change, string date)
        {
            SqlConnection con = new SqlConnection(connstring);
            string sql = "insert into TblReports  values (@Customer,@Cashier,@Cash,@Transaction,@Change,@Date)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Customer", customer);
            cmd.Parameters.AddWithValue("@Cashier", cashier);
            cmd.Parameters.AddWithValue("@Cash", cash);
            cmd.Parameters.AddWithValue("@Transaction", trans);
            cmd.Parameters.AddWithValue("@Change", change);
            cmd.Parameters.AddWithValue("@date", date);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Reports> GetAllReports()
        {
            List<Reports> Listreports = new List<Reports>();

            SqlConnection con = new SqlConnection(connstring);
            string sql = "SELECT * FROM TblReports";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Reports newreports= new Reports();

                newreports.Id = (int)dr["Id"];
                newreports.Customer = dr["Customer"].ToString();
                newreports.Cashier = dr["Cashier"].ToString();
                newreports.Cash = (double)dr["Cash"];
                newreports.Transaction = (double)dr["Transaction"];
                newreports.Change = (double)dr["Change"];
                newreports.Date = dr["date"].ToString();

                Listreports.Add(newreports);
            }

            return Listreports;
        }
    }
}
