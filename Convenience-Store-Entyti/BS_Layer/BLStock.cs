using Convenience_Store_Entyti.UserControlGroup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLStock
    {
        public DataTable GetAvailableProducts()
        {
            
            using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
            {
                var query = from lp in dbContext.FN_AvailableProducts()
                            select new
                            {
                                lp.pID,
                                lp.pName,
                                lp.amountImport,
                                lp.amountInStock
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("pID");
                dt.Columns.Add("pName");
                dt.Columns.Add("amountImport", typeof(int));
                dt.Columns.Add("amountInStock", typeof(int));

                foreach (var row in query)
                {
                    dt.Rows.Add(row.pID, row.pName, row.amountImport, row.amountInStock);
                }

                return dt;
            }
        }
        public DataTable TakeStock()
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            var stos = from p in qlstoreEntity.Stocks select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("batchID");
            dt.Columns.Add("imDate");
            dt.Columns.Add("amountofProduct");
            dt.Columns.Add("sID");
            foreach (var p in stos)
            {
                dt.Rows.Add(p.batchID, p.imDate, p.amountofProduct,p.sID);
            }
            return dt;
        }
        public bool AddStock(string batchID, DateTime imDate, int amountofProduct,string sID, ref string err)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            Stock sto = new Stock();
            sto.batchID = batchID; sto.imDate = imDate; sto.amountofProduct = amountofProduct;sto.sID = sID;
            qlstoreEntity.Stocks.Add(sto);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool DeleteStock(ref string err, string batchID)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            Stock sto = new Stock();
            sto.batchID = batchID;
            qlstoreEntity.Stocks.Attach(sto);
            qlstoreEntity.Stocks.Remove(sto);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateStock(string batchID, DateTime imDate, int amountofProduct, string sID, ref string err)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password); 
            var stoQuery = (from sto in qlstoreEntity.Stocks
                           where sto.batchID == batchID
                           select sto).SingleOrDefault();
            if (stoQuery != null)
            {
                stoQuery.imDate = imDate;
                stoQuery.amountofProduct = amountofProduct;
                stoQuery.sID = sID;
                qlstoreEntity.SaveChanges();
            }
            return true;
        }
    }
}
