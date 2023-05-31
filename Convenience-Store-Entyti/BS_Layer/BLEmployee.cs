using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convenience_Store_Entyti.UserControlGroup;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLEmployee
    {

        public DataTable FindEmployeesByName(string name)
        {
            try
            {
               
                using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var query = dbContext.Database.SqlQuery<Employee>(
                        "SELECT * FROM dbo.FindEmployeesByName(@name)",
                        new SqlParameter("@name", name)
                    );

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("EID", typeof(string));
                    dataTable.Columns.Add("EName", typeof(string));
                    dataTable.Columns.Add("EDateOfBirth", typeof(DateTime));
                    dataTable.Columns.Add("EGender", typeof(bool));
                    dataTable.Columns.Add("EPhone", typeof(string));
                    dataTable.Columns.Add("EAddress", typeof(string));
                    dataTable.Columns.Add("EPosition", typeof(string));
                    dataTable.Columns.Add("ESalary", typeof(float));
                    dataTable.Columns.Add("EUserName", typeof(string));
                    dataTable.Columns.Add("EPass", typeof(string));

                    foreach (var row in query)
                    {
                        dataTable.Rows.Add(
                            row.eID.ToString(),
                            row.eName,
                            row.eBirthdate,
                            row.eGender,
                            row.ePhone,
                            row.eAddress,
                            row.ePosition,
                            (float)row.eSalary,
                            row.eUsername,
                            row.ePassword
                        );
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving employees: " + ex.Message);
                return null;
            }
        }
        public DataTable GetHighestIncomeEmployees(DateTime month)
        {   

            try
            {
               
                using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var parameter = new SqlParameter("@month", month.Date);

                    var dataTable = new DataTable();
                    using (var command = dbContext.Database.Connection.CreateCommand())
                    {
                        command.CommandText = "spud_HighestIncome";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(parameter);

                        dbContext.Database.Connection.Open();
                        dataTable.Load(command.ExecuteReader());
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving highest income employees: " + ex.Message);
                return null;
            }
        }

        public DataTable GetMostDiligentEmployees(DateTime month)
        {
            try
            {
               
                using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var parameter = new SqlParameter("@month", month);

                    var dataTable = new DataTable();
                    using (var command = dbContext.Database.Connection.CreateCommand())
                    {
                        command.CommandText = "spud_MostDiligentEmployee";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(parameter);

                        dbContext.Database.Connection.Open();
                        dataTable.Load(command.ExecuteReader());
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving most diligent employees: " + ex.Message);
                return null;
            }
        }
        public DataTable GetEmployeePayrollAnalysis(DateTime month)
        {
            using (var dbContext = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
            { 
                var query = from ep in dbContext.FN_SumSalaryByPosition(month)
                            select new
                            {
                                ep.Position,
                                ep.TotalSalary
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("Position");
                dt.Columns.Add("TotalSalary", typeof(decimal));

                foreach (var row in query)
                {
                    dt.Rows.Add(row.Position, row.TotalSalary);
                }

                return dt;
            }
        }

        public DataTable GetEmployeePayroll(DateTime month)
        {
           
            using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
            {
                var query = from ep in dbContext.FN_TotalSalary(month)
                            select new
                            {
                                ep.eID,
                                ep.eName,
                                ep.eGender,
                                ep.ePhoneNum,
                                ep.salaryPerHour,
                                ep.workingHour,
                                ep.totalSalary
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("eID");
                dt.Columns.Add("eName");
                dt.Columns.Add("eGender");
                dt.Columns.Add("ePhoneNum");
                dt.Columns.Add("salaryPerHour", typeof(double));
                dt.Columns.Add("workingHour", typeof(double));
                dt.Columns.Add("totalSalary", typeof(double));

                foreach (var row in query)
                {
                    dt.Rows.Add(row.eID, row.eName, row.eGender, row.ePhoneNum, row.salaryPerHour, row.workingHour, row.totalSalary);
                }

                return dt;
            }
        }

        public bool CheckAccountCredentials(string username, string password, string role)
        {
            try
            {
               
                using (var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password))
                {
                    var employee = dbContext.Employees.FirstOrDefault(e =>
                        e.eUsername == username && e.ePassword == password && e.ePosition == role);

                    return employee != null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public DataTable TakeEmployee()
        {
           
            var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
                var det = from p in dbContext.Employees select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("eID");
            dt.Columns.Add("eName");
            dt.Columns.Add("eBirthdate");
            dt.Columns.Add("eGender");
            dt.Columns.Add("ePhone");
            dt.Columns.Add("eAddress");
            dt.Columns.Add("ePosition");
            dt.Columns.Add("eSalary");
            dt.Columns.Add("eUsername");
            dt.Columns.Add("ePassword");
            foreach (var p in det)
            {
                dt.Rows.Add(p.eID, p.eName, p.eBirthdate, p.eGender,p.ePhone,p.eAddress,p.ePosition,p.eSalary,p.eUsername,p.ePassword);
            }
            return dt;
        }
        public bool AddEmployee(string EID, string EName, DateTime EDateOfBirth, bool EGender, string EPhone, string EAddress, string EPosition, float ESalary,string EUserName, string EPass, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
               // ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
               
                var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
                    // create a new instance of the Employee object
                    Employee emp = new Employee();

                // set the properties of the Employee object
                emp.eID = EID;
                emp.eName = EName;
                emp.eBirthdate = EDateOfBirth;
                emp.eGender = EGender;
                emp.ePhone = EPhone;
                emp.eAddress = EAddress;
                emp.ePosition = EPosition;
                emp.eSalary = ESalary;
                emp.eUsername = EUserName;
                emp.ePassword = EPass;

                // add the Employee object to the DbContext
                dbContext.Employees.Add(emp);

                // save changes to the database
                dbContext.SaveChanges();

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
        public bool UpdateEmployee(string EID, string EName, DateTime EDateOfBirth, bool EGender, string EPhone, string EAddress, string EPosition, float ESalary, string EUserName, string EPass, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
               
                var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

                    // retrieve the existing employee from the database using the specified EID
                    Employee emp = dbContext.Employees.FirstOrDefault(e => e.eID == EID);

                if (emp != null)
                {
                    // update the properties of the Employee object
                    emp.eName = EName;
                    emp.eBirthdate = EDateOfBirth;
                    emp.eGender = EGender;
                    emp.ePhone = EPhone;
                    emp.eAddress = EAddress;
                    emp.ePosition = EPosition;
                    emp.eSalary = ESalary;
                    emp.eUsername = EUserName;
                    emp.ePassword = EPass;

                    // save changes to the database
                    dbContext.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    // set the "err" parameter to indicate that the employee could not be found
                    err = "Employee with EID " + EID + " could not be found.";

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
        public bool DeleteEmployee(string eID, ref string err)
        {
            try
            {
                // create a new instance of the DbContext object
               
                var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

                    // retrieve the existing employee from the database using the specified EID
                    Employee emp = dbContext.Employees.FirstOrDefault(e => e.eID == eID);

                if (emp != null)
                {
                    // remove the employee from the DbContext object and save changes to the database
                    dbContext.Employees.Remove(emp);
                    dbContext.SaveChanges();

                    // return true to indicate success
                    return true;
                }
                else
                {
                    // set the "err" parameter to indicate that the employee could not be found
                    err = "Employee with EID " + eID + " could not be found.";

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
