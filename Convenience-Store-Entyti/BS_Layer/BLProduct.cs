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
        public DataTable GetMostFavoriteProducts()
        {
            try
            {
                using (var dbContext = new ConvenienceStoreManagementEntities1())
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
                using (var dbContext = new ConvenienceStoreManagementEntities1())
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
            using (var context = new ConvenienceStoreManagementEntities1())
            {
                string query = "EXEC [dbo].[FindProductByTypeName] @TypeName";
                var products = context.Database.SqlQuery<Product>(query, new SqlParameter("@TypeName", nameProduct));

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
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
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
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
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
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
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
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
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
