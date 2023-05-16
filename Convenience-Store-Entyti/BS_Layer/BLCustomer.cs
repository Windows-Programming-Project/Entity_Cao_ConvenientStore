using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLLoyalCustomers
    {
        public DataTable TakeLoyalCustomers()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var det = from p in qlstoreEntity.LoyalCustomers select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("cID");
            dt.Columns.Add("cName");
            dt.Columns.Add("cTotalpay");
            dt.Columns.Add("cPhoneNum");
            dt.Columns.Add("rName");
            foreach (var p in det)
            {
                dt.Rows.Add(p.cID, p.cName,p.cTotalpay, p.cPhoneNum, p.rName);
            }
            return dt;
        }
        public bool AddLoyalCustomers(string cID, string cName, float TotalPay, string cPhone, string rName, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                // create a new instance of the LoyalCustomers object and set its properties
                LoyalCustomer cust = new LoyalCustomer();
                cust.cID = cID;
                cust.cName = cName;
                cust.cTotalpay = TotalPay;
                cust.cPhoneNum = cPhone;
                cust.rName = rName;

                // add the new LoyalCustomers to the DbContext object and save changes to the database
                qlstoreEntity.LoyalCustomers.Add(cust);
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
        public bool UpdateLoyalCustomers(string cID, string cName, float TotalPay, string cPhone, string rName, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                // retrieve the existing LoyalCustomers from the database using the specified cID
                LoyalCustomer cust = qlstoreEntity.LoyalCustomers.FirstOrDefault(c => c.cID == cID);

                if (cust != null)
                {
                    // update the LoyalCustomers's properties with the provided parameters
                    cust.cName = cName;
                    cust.cTotalpay = TotalPay;
                    cust.cPhoneNum = cPhone;
                    cust.rName = rName;

                    // save changes to the database
                    qlstoreEntity.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    // set the "err" parameter to indicate that the LoyalCustomers could not be found
                    err = "LoyalCustomers with cID " + cID + " could not be found.";

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
        public bool DeleteLoyalCustomers(string cID, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                // retrieve the LoyalCustomers to be deleted from the database using the specified cID
                LoyalCustomer cust = qlstoreEntity.LoyalCustomers.FirstOrDefault(c => c.cID == cID);

                if (cust != null)
                {
                    // remove the LoyalCustomers from the DbContext
                    qlstoreEntity.LoyalCustomers.Remove(cust);

                    // save changes to the database
                    qlstoreEntity.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    // set the "err" parameter to indicate that the LoyalCustomers could not be found
                    err = "LoyalCustomers with cID " + cID + " could not be found.";

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
        public DataTable GetLoyalCustomerMostProducts()
        {
            try
            {
                using (var dbContext = new ConvenienceStoreManagementEntities1())
                {
                    var query = "SELECT TOP (1000) [cID], [cName], [TotalProducts] FROM [ConvenienceStoreManagement].[dbo].[LoyalCustomerMostProducts]";

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
                Console.WriteLine("Error retrieving data from LoyalCustomerMostProducts: " + ex.Message);
                return null;
            }
        }

        public string GetCustomerIdByPhoneNumber(string phoneNumber)
        {
            try
            {
                using (var dbContext = new ConvenienceStoreManagementEntities1())
                {
                    var customer = dbContext.LoyalCustomers.FirstOrDefault(c => c.cPhoneNum == phoneNumber);

                    if (customer != null)
                    {
                        return customer.cID;
                    }
                    else
                    {
                        Console.WriteLine("Customer not found for the given phone number.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving customer ID: " + ex.Message);
                return null;
            }
        }
    }
}
