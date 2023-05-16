using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Convenience_Store_Entyti.BS_Layer
{
    class BLInvoice
    {
        public int CountInvoiceIDs()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            int count = qlstoreEntity.Invoices.Count();
            return count;
        }
        public DataTable TakeInvoice()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var inv = from p in qlstoreEntity.Invoices select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("iID");
            dt.Columns.Add("eID");
            dt.Columns.Add("cID");
            dt.Columns.Add("iDate");
            dt.Columns.Add("iTotalpay");
            dt.Columns.Add("iFinalTotalpay");
            foreach (var p in inv)
            {
                dt.Rows.Add(p.iID, p.eID, p.cID, p.iDate, p.iTotalpay, p.iFinalTotalpay);
            }
            return dt;
        }
        public bool AddInvoice(string iID, string eID, string cID, DateTime iDate, float iTotal,float iFinalTotalpay ,ref string err)
        {
            try
            {
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
                Invoice inv = new Invoice();
                inv.iID = iID;
                inv.eID = eID;
                inv.cID = string.IsNullOrEmpty(cID) ? null : cID;
                inv.iDate = iDate;
                inv.iTotalpay = iTotal;
                inv.iFinalTotalpay = iFinalTotalpay;
                qlstoreEntity.Invoices.Add(inv);
                qlstoreEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }
        public bool DeleteInvoice(ref string err, string iID, string eID, string cID)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            Invoice inv = new Invoice();
            inv.iID = iID;
            inv.eID = eID;
            inv.cID = string.IsNullOrEmpty(cID) ? null : cID;
            qlstoreEntity.Invoices.Attach(inv);
            qlstoreEntity.Invoices.Remove(inv);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateInvoice(string iID, string eID, string cID, DateTime iDate, ref string err)
        {
            try
            {
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
                var maQuery = (from inv in qlstoreEntity.Invoices
                               where inv.iID == iID
                               select inv).SingleOrDefault();

                if (maQuery != null)
                {
                    maQuery.eID = eID;
                    maQuery.cID = string.IsNullOrEmpty(cID) ? null : cID;
                    maQuery.iDate = iDate;

                    // Retrieve iTotalpay and iFinalTotalpay from the database
                    //float iTotal = maQuery.iTotalpay;
                    //float iFinaltotalpay = maQuery.iFinalTotalpay;

                    qlstoreEntity.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }
    }
}
