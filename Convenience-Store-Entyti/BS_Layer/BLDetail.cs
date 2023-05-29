using Convenience_Store_Entyti.UserControlGroup;
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
            try
            {
               
                using (var dbContext = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var query = from detail in dbContext.Invoice_Detail
                                select new
                                {
                                    detail.iID,
                                    detail.pID,
                                    detail.dAmount,
                                    detail.dPrice
                                };

                    DataTable dt = new DataTable();
                    dt.Columns.Add("iID");
                    dt.Columns.Add("pID");
                    dt.Columns.Add("dAmount");
                    dt.Columns.Add("dPrice");

                    foreach (var item in query)
                    {
                        dt.Rows.Add(item.iID, item.pID, item.dAmount, item.dPrice);
                    }

                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving invoice details: " + ex.Message);
                return null;
            }
        }
        public DataTable TakeInvoice_Detail_order(string invoiceID)
        {
           
            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
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
           
            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
               
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
            try
            {
               
                using (var dbContext = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var invoiceDetail = dbContext.Invoice_Detail.FirstOrDefault(detail => detail.iID == iID && detail.pID == pID);

                    if (invoiceDetail != null)
                    {
                        dbContext.Invoice_Detail.Remove(invoiceDetail);
                        dbContext.SaveChanges();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                err = "Error deleting invoice detail: " + ex.Message;
                return false;
            }
        }
        public bool UpdateInvoice_Detail(string iID, string pID, int dAmount, float dPrice, ref string err)
        {
           
            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
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
