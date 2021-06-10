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
    public partial class FmReports : Form
    {
        readonly string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\PaintStoreDB.mdf;Integrated Security=True;Connect Timeout=30";
        readonly private ReportsSvs newreport = new ReportsSvs();
        public FmReports()
        {
            InitializeComponent();
        }

        private void FmReports_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        public void UpdateDgv()
        {
            
            List<Reports> dgv = newreport.GetAllReports();
            DGV_Reports.DataSource = dgv;
        }

    }
}
