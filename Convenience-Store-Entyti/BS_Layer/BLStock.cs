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
            using (var context = new ConvenienceStoreManagementEntities1())
            {
                var query = from lp in context.FN_AvailableProducts()
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
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
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
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            Stock sto = new Stock();
            sto.batchID = batchID; sto.imDate = imDate; sto.amountofProduct = amountofProduct;sto.sID = sID;
            qlstoreEntity.Stocks.Add(sto);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool DeleteStock(ref string err, string batchID)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            Stock sto = new Stock();
            sto.batchID = batchID;
            qlstoreEntity.Stocks.Attach(sto);
            qlstoreEntity.Stocks.Remove(sto);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateStock(string batchID, DateTime imDate, int amountofProduct, string sID, ref string err)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
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
