using Convenience_Store_Entyti.UserControlGroup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Convenience_Store_Entyti.BS_Layer
{
   
    class BLInvoice
    {
       
        public int CountInvoiceIDs()
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            int count = qlstoreEntity.Invoices.Count();
            return count;
        }
        public DataTable GetInvoiceTable(string invoiceID)
        {
            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            // Retrieve the invoice data for the specified invoiceID
            var invoice = qlstoreEntity.Invoices.FirstOrDefault(p => p.iID == invoiceID);
            if (invoice == null)
            {
                return null; // Return null if the invoice is not found
            }

            // Retrieve the Employee and Customer names based on their IDs
            var employee = qlstoreEntity.Employees.FirstOrDefault(e => e.eID == invoice.eID);
            var customer = qlstoreEntity.LoyalCustomers.FirstOrDefault(c => c.cID == invoice.cID);
            if (employee == null )
            {
                
                return null; // Return null if the employee or customer is not found
            }
            if( customer == null)
            {
                customer = new LoyalCustomer { cName = "none" };
            }

            // Create an invoice DataTable and populate it with data
            DataTable invoiceDataTable = new DataTable();
            invoiceDataTable.Columns.Add("InvoiceID", typeof(string));
            invoiceDataTable.Columns.Add("EmployeeName", typeof(string));
            invoiceDataTable.Columns.Add("CustomerName", typeof(string));
            invoiceDataTable.Columns.Add("InvoiceDate", typeof(DateTime));
            invoiceDataTable.Columns.Add("TotalPay", typeof(decimal));
            invoiceDataTable.Columns.Add("FinalTotalPay", typeof(decimal));
            invoiceDataTable.Rows.Add(invoice.iID, employee.eName, customer.cName, invoice.iDate, invoice.iTotalpay, invoice.iFinalTotalpay);

            return invoiceDataTable;
        }

        public DataTable GetOrderDetailTable(string invoiceID)
        {
            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            // Retrieve the order detail data for the specified invoiceID
            var orderDetails = from od in qlstoreEntity.Invoice_Detail
                               join p in qlstoreEntity.Products on od.pID equals p.pID
                               where od.iID == invoiceID
                               select new
                               {
                                   od.iID,
                                   p.pName,
                                   od.dAmount,
                                   od.dPrice
                               };

            // Create an order detail DataTable and populate it with data
            DataTable orderDetailDataTable = new DataTable();
            orderDetailDataTable.Columns.Add("InvoiceID", typeof(string));
            orderDetailDataTable.Columns.Add("ProductName", typeof(string));
            orderDetailDataTable.Columns.Add("Quantity", typeof(int));
            orderDetailDataTable.Columns.Add("Price", typeof(decimal));
            foreach (var detail in orderDetails)
            {
                orderDetailDataTable.Rows.Add(detail.iID, detail.pName, detail.dAmount, detail.dPrice);
            }

            return orderDetailDataTable;
        }



        public DataTable TakeInvoice()
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1(UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            var inv = from p in qlstoreEntity.Invoices select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("iID");
            dt.Columns.Add("eID");
            dt.Columns.Add("cID");
            dt.Columns.Add("iDate");
            dt.Columns.Add("iTotalpay");
            dt.Columns.Add("iFinalTotalpay");
            foreach (var p in inv)
            {
                dt.Rows.Add(p.iID, p.eID, p.cID, p.iDate, p.iTotalpay, p.iFinalTotalpay);
            }
            return dt;
        }
        public bool AddInvoice(string iID, string eID, string cID, DateTime iDate, float iTotal,float iFinalTotalpay ,ref string err)
        {
            try
            {

                
                var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
                Invoice inv = new Invoice();
                inv.iID = iID;
                inv.eID = eID;
                inv.cID = string.IsNullOrEmpty(cID) ? null : cID;
                inv.iDate = iDate;
                inv.iTotalpay = iTotal;
                inv.iFinalTotalpay = iFinalTotalpay;
                qlstoreEntity.Invoices.Add(inv);
                qlstoreEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }
        public bool DeleteInvoice(ref string err, string iID, string eID, string cID)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            Invoice inv = new Invoice();
            inv.iID = iID;
            inv.eID = eID;
            inv.cID = string.IsNullOrEmpty(cID) ? null : cID;
            qlstoreEntity.Invoices.Attach(inv);
            qlstoreEntity.Invoices.Remove(inv);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateInvoice(string iID, string eID, string cID, DateTime iDate, ref string err)
        {
            try
            {
                
                var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
                var maQuery = (from inv in qlstoreEntity.Invoices
                               where inv.iID == iID
                               select inv).SingleOrDefault();

                if (maQuery != null)
                {
                    maQuery.eID = eID;
                    maQuery.cID = string.IsNullOrEmpty(cID) ? null : cID;
                    maQuery.iDate = iDate;

                    // Retrieve iTotalpay and iFinalTotalpay from the database
                    //float iTotal = maQuery.iTotalpay;
                    //float iFinaltotalpay = maQuery.iFinalTotalpay;

                    qlstoreEntity.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }
    }
}
