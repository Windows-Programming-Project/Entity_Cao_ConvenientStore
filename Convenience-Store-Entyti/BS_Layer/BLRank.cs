using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLRank
    {
        public DataTable TakeRanks()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var det = from p in qlstoreEntity.Ranks select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("rName");
            dt.Columns.Add("rDiscount");

            foreach (var p in det)
            {
                dt.Rows.Add( p.rName, p.rDiscount);
            }
            return dt;
        }
        public bool AddRanks(string rName, float rDiscount, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                // create a new instance of the LoyalCustomers object and set its properties
               Rank rank = new Rank();
                rank.rName = rName;
                rank.rDiscount = rDiscount;

                // add the new LoyalCustomers to the DbContext object and save changes to the database
                qlstoreEntity.Ranks.Add(rank);
                qlstoreEntity.SaveChanges();

                // return true to indicate success
                return true;
            }
            catch (Exception ex)
            {
                // set the "err" parameter to the error message
                err = ex.Message;

                // return false to indicate failure
                return false;
            }
        }
        public bool UpdateRanks(string rName, float rDiscount, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                // retrieve the existing LoyalCustomers from the database using the specified cID
                Rank rank = qlstoreEntity.Ranks.FirstOrDefault(c => c.rName == rName);

                if (rank != null)
                {
                    // update the LoyalCustomers's properties with the provided parameters
                    rank.rDiscount = rDiscount;
                    rank.rName = rName;

                    // save changes to the database
                    qlstoreEntity.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    // set the "err" parameter to indicate that the LoyalCustomers could not be found
                    err = "Rank with rName " + rName + " could not be found.";

                    // return false to indicate failure
                    return false;
                }
            }
            catch (Exception ex)
            {
                // set the "err" parameter to the error message
                err = ex.Message;

                // return false to indicate failure
                return false;
            }
        }
        public bool DeleteRanks(string rName, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

              
                Rank rank = qlstoreEntity.Ranks.FirstOrDefault(c => c.rName == rName);

                if (rank != null)
                {
                    
                    qlstoreEntity.Ranks.Remove(rank);

                    // save changes to the database
                    qlstoreEntity.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    
                    err = "Rank with rName " + rName + " could not be found.";

                    // return false to indicate failure
                    return false;
                }
            }
            catch (Exception ex)
            {
                // set the "err" parameter to the error message
                err = ex.Message;

                // return false to indicate failure
                return false;
            }
        }
    }
}
