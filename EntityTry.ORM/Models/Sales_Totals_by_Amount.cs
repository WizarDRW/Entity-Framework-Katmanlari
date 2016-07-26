using System;
using System.Collections.Generic;

namespace EntityTry.ORM.Models
{
    public partial class Sales_Totals_by_Amount
    {
        public Nullable<decimal> SaleAmount { get; set; }
        public int OrderID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}
