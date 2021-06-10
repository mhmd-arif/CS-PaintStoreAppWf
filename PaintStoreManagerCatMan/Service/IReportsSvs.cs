using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;

namespace PaintStoreManagerCatMan.Service
{
    interface IReportsSvs
    {
        List<Reports> GetAllReports();
        void Add(string customer, string cashier, double cash,double trans, double change , string date);
     
    }
}
