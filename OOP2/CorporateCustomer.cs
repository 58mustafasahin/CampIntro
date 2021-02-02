using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Corporate-Tüzel
    //miras inheritance
    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
