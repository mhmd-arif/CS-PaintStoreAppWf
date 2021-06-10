using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintStoreManagerCatMan.Forms;
namespace PaintStoreManagerCatMan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmLogin());
            //SELECT TOP 1 * FROM Customers ORDER BY CustomerID DESC;
        }
    }
}
