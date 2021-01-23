using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg01OOP2
{
    /// <summary>
    /// Tüzel Kişilik
    /// Miras Inheritance
    /// </summary>
    class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}