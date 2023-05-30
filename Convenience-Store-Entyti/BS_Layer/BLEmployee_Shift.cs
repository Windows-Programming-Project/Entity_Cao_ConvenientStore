using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Convenience_Store_Entyti;
using Convenience_Store_Entyti.UserControlGroup;



namespace Convenience_Store_Entyti.BS_Layer
{
    class BLEmployee_Shift
    {
        public DataTable TakeShift()
        {

            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            var shifts = from s in qlstoreEntity.Shifts select s;

            DataTable dt = new DataTable();
            dt.Columns.Add("shID");
            dt.Columns.Add("StartTime", typeof(TimeSpan));
            dt.Columns.Add("EndTime", typeof(TimeSpan));

            // Assuming you have access to the Shift instances, you can loop through them to populate the DataTable.
            foreach (var shift in shifts)
            {
                dt.Rows.Add(shift.shID, shift.StartTime, shift.EndTime);
            }

            return dt;
        }
        public DataTable TakeEmployeeShift()
        {
           
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            
            var Employees = from p in qlstoreEntity.Employees select p;
          
            DataTable dt = new DataTable();
            dt.Columns.Add("eID");
            dt.Columns.Add("shID");

            // Assuming you have access to the Employee and Shift instances, you can loop through them to populate the DataTable.
            foreach (var employee in Employees)
            {
                foreach (var shift in employee.Shifts)
                {
                    dt.Rows.Add(employee.eID, shift.shID);
                }
            }
        
            return dt;
        }

        public bool AddShift(string shID, TimeSpan? startTime, TimeSpan? endTime, ref string err)
        {
            try
            {
                using (var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    Shift shift = new Shift();
                    shift.shID = shID;
                    shift.StartTime = startTime;
                    shift.EndTime = endTime;

                    qlstoreEntity.Shifts.Add(shift);
                    qlstoreEntity.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool UpdateShift(string shID, TimeSpan? startTime, TimeSpan? endTime, ref string err)
        {
            try
            {
                using (var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var existingShift = qlstoreEntity.Shifts.Find(shID);
                    if (existingShift != null)
                    {
                        existingShift.StartTime = startTime;
                        existingShift.EndTime = endTime;
                        qlstoreEntity.SaveChanges();

                        return true;
                    }
                    else
                    {
                        err = "Shift not found";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool DeleteShift(string shID, ref string err)
        {
            try
            {
                using (var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var existingShift = qlstoreEntity.Shifts.Find(shID);
                    if (existingShift != null)
                    {
                        qlstoreEntity.Shifts.Remove(existingShift);
                        qlstoreEntity.SaveChanges();

                        return true;
                    }
                    else
                    {
                        err = "Shift not found";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }


    }

}
