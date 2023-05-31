using Convenience_Store_Entyti.UserControlGroup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLProduct
    {
        public DataTable GetProductDetails()
        {
            using (var dbContext = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
            {
                var query = from p in dbContext.Products
                            join id in dbContext.Invoice_Detail on p.pID equals id.pID into invoiceDetails
                            from id in invoiceDetails.DefaultIfEmpty()
                            join s in dbContext.Stocks on p.batchID equals s.batchID into stockDetails
                            from s in stockDetails.DefaultIfEmpty()
                            group new { p, id, s } by new { p.pName } into g
                            select new
                            {
                                ProductName = g.Key.pName,
                                BoughtAmount = g.Sum(x => x.id != null ? x.id.dAmount : 0),
                                ImportedAmount = g.Sum(x => x.s != null ? x.s.amountofProduct : 0)
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("ProductName");
                dt.Columns.Add("BoughtAmount", typeof(int));
                dt.Columns.Add("ImportedAmount", typeof(int));

                foreach (var row in query)
                {
                    dt.Rows.Add(row.ProductName, row.BoughtAmount, row.ImportedAmount);
                }

                return dt;
            }
        }

        public DataTable GetMostFavoriteProducts()
        {
            try
            {
                
                using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var query = "SELECT TOP (1000) [pID], [pName], [TotalAmount] FROM [ConvenienceStoreManagement].[dbo].[MostFavoriteProducts]";

                    var dataTable = new DataTable();
                    using (var command = dbContext.Database.Connection.CreateCommand())
                    {
                        command.CommandText = query;

                        dbContext.Database.Connection.Open();
                        dataTable.Load(command.ExecuteReader());
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving most favorite products: " + ex.Message);
                return null;
            }
        }

        public DataTable GetLeastFavoriteProducts()
        {
            try
            {
                
                using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var query = "SELECT TOP (1000) [pID], [pName], [TotalAmount] FROM [ConvenienceStoreManagement].[dbo].[LeastFavoriteProducts]";

                    var dataTable = new DataTable();
                    using (var command = dbContext.Database.Connection.CreateCommand())
                    {
                        command.CommandText = query;

                        dbContext.Database.Connection.Open();
                        dataTable.Load(command.ExecuteReader());
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving least favorite products: " + ex.Message);
                return null;
            }
        }

        public DataTable FindProduct(string nameProduct)
        {
           
            DataTable dt = new DataTable();
            dt.Columns.Add("pID");
            dt.Columns.Add("pName");
            dt.Columns.Add("pPrice");
            dt.Columns.Add("tID");
            dt.Columns.Add("batchID");
            
            using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
            {
                string query = "EXEC [dbo].[FindProductByTypeName] @TypeName";
                var products = dbContext.Database.SqlQuery<Product>(query, new SqlParameter("@TypeName", nameProduct));

                // Process the retrieved products as needed
                foreach (var product in products)
                {
                    DataRow row = dt.NewRow();
                    row["pID"] = product.pID;
                    row["pName"] = product.pName;
                    row["pPrice"] = product.pPrice;
                    row["tID"] = product.tID;
                    row["batchID"] = product.batchID;

                    dt.Rows.Add(row);
                }
            }
            return dt;

        }
        public DataTable TakeProduct()
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            var pro = from p in qlstoreEntity.Products select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("pID");
            dt.Columns.Add("pName");
            dt.Columns.Add("pPrice");
            dt.Columns.Add("tID");
            dt.Columns.Add("batchID");
            foreach (var p in pro)
            {
                dt.Rows.Add(p.pID, p.pName, p.pPrice, p.tID, p.batchID);
            }
            return dt;
        }
        public bool AddProduct(string pID, string pName, float pPrice, string tID, string batchID, ref string err)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            Product det = new Product();
            det.pID = pID;
            det.pName = pName;
            det.pPrice = pPrice;
            det.tID = tID;
            det.batchID = batchID;
            qlstoreEntity.Products.Add(det);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool DeleteProduct(ref string err, string pID, string tID, string batchID)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            Product det = new Product();
            det.pID = pID;
            det.tID = tID;
            det.batchID = batchID;
            qlstoreEntity.Products.Attach(det);
            qlstoreEntity.Products.Remove(det);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateProduct(string pID, string pName, float pPrice, string tID, string batchID, ref string err)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            var maQuery = (from det in qlstoreEntity.Products
                           where det.pID == pID
                           select det).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.pName = pName;
                maQuery.pPrice = pPrice;
                maQuery.tID = tID;
                maQuery.batchID = batchID;
                qlstoreEntity.SaveChanges();
            }
            return true;
        }
    }
}
