using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLEmployeeLate
    {
        public DataTable TakeEmployeeLate()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var det = from p in qlstoreEntity.EmployeeLates select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("eID");
            dt.Columns.Add("LateDate");
            dt.Columns.Add("StartTime");
            dt.Columns.Add("EndTime");
            dt.Columns.Add("shID");
            foreach (var p in det)
            {
                dt.Rows.Add(p.eID, p.LateDate, p.StartTime, p.EndTime, p.shID);
            }
            return dt;
        }
        public bool AddEmployeeLate(string eID, DateTime LateDate, TimeSpan StartTime, TimeSpan EndTime, string shID, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                EmployeeLate emplate = new EmployeeLate();
                emplate.eID = eID;
                emplate.LateDate = LateDate;
                emplate.StartTime = StartTime;
                emplate.EndTime = EndTime;
                emplate.shID = shID;
               
                qlstoreEntity.EmployeeLates.Add(emplate);
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
        public bool UpdateEmployeeLate(string eID, DateTime LateDate, TimeSpan StartTime, TimeSpan EndTime, string shID, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                // retrieve the existing LoyalCustomers from the database using the specified cID
                EmployeeLate emplate = qlstoreEntity.EmployeeLates.FirstOrDefault(c => c.eID == eID);

                if (emplate != null)
                {
                    emplate.LateDate = LateDate;
                    emplate.StartTime = StartTime;
                    emplate.EndTime = EndTime;
                    emplate.shID = shID;

                    // save changes to the database
                    qlstoreEntity.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    err = "Employee with eID " + eID + " could not be found.";

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
        public bool DeleteLoyalCustomers(string eID, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
                ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();

                // retrieve the LoyalCustomers to be deleted from the database using the specified cID
               EmployeeLate emplate = qlstoreEntity.EmployeeLates.FirstOrDefault(c => c.eID == eID);

                if (emplate != null)
                {
                    // remove the LoyalCustomers from the DbContext
                    qlstoreEntity.EmployeeLates.Remove(emplate);

                    // save changes to the database
                    qlstoreEntity.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    // set the "err" parameter to indicate that the LoyalCustomers could not be found
                    err = "Employee with eID " + eID + " could not be found.";

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
