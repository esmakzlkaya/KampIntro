using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Customer : ebeveyn
    class CorporateCustomer :Customer //miras - inheritance
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
