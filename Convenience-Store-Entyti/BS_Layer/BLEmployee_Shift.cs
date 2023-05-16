using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Convenience_Store_Entyti;




namespace Convenience_Store_Entyti.BS_Layer
{
    class BLEmployee_Shift
    {
        public DataTable TakeEmployeeShift()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
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
    }

}
