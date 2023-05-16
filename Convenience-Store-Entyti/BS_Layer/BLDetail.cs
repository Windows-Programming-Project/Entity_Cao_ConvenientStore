using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLInvoice_Detail
    {
        public DataTable TakeInvoice_Detail()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var det = from p in qlstoreEntity.Invoice_Detail select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("iID");
            dt.Columns.Add("pID");
            dt.Columns.Add("dAmount");
            dt.Columns.Add("dPrice");
            foreach (var p in det)
            {
                dt.Rows.Add(p.iID, p.pID, p.dAmount, p.dPrice);
            }
            return dt;
        }
        public DataTable TakeInvoice_Detail_order(string invoiceID)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            // Retrieve the Invoice_Detail records and join with the Product table to get the product names
            var detailQuery = from d in qlstoreEntity.Invoice_Detail
                              join p in qlstoreEntity.Products on d.pID equals p.pID
                              where d.iID == invoiceID
                              select new { p.pName, d.dAmount, d.dPrice };

            DataTable dt = new DataTable();
            
            dt.Columns.Add("pName");
            dt.Columns.Add("dAmount");
            dt.Columns.Add("dPrice");
           foreach (var record in detailQuery)
            {
                dt.Rows.Add(record.pName, record.dAmount, record.dPrice);
            }
            return dt;
        }
        public bool AddInvoice_Detail(string iID, string pID, int dAmount, float dPrice, ref string err)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            Invoice_Detail det = new Invoice_Detail();
            det.iID = iID; 
            det.pID = pID; 
            det.dAmount = dAmount;
            det.dPrice = dPrice;
            qlstoreEntity.Invoice_Detail.Add(det);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool DeleteInvoice_Detail(ref string err, string iID, string pID)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            Invoice_Detail det = new Invoice_Detail();
            det.iID = iID;
            det.pID = pID;
            qlstoreEntity.Invoice_Detail.Attach(det);
            qlstoreEntity.Invoice_Detail.Remove(det);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateInvoice_Detail(string iID, string pID, int dAmount, float dPrice, ref string err)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var maQuery = (from det in qlstoreEntity.Invoice_Detail
                           where det.iID == iID && det.pID == pID
            select det).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.dAmount = dAmount;
                maQuery.dPrice = dPrice;
                qlstoreEntity.SaveChanges();
            }
            return true;
        }
    }
}
