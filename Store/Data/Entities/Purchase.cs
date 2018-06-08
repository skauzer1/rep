using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Entities
{
    public class Purchase
    {
            public int PurchaseId { get; set; }
            public string Person { get; set; }          
            public int GoodId { get; set; }
            public DateTime Date { get; set; }
    }
}
