using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    public class Order
    {
        public int InvoiceID { get; set; }
        public int EmployeeName { get; set; }
        public int CustomerName { get; set; }
        public DateTime InvoiceDate { get; set; }

        public decimal TotalPay { get; set; }
        public decimal FinalTotalPay { get; set; }

    }

    public class detail_order
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
