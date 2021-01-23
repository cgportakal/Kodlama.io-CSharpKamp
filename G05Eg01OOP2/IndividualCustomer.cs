using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg01OOP2
{
    /// <summary>
    /// Gerçek Kişilik
    /// Miras Inheritance
    /// Tüzel ve Gerçek müşteriler için ortak olan özellikler bir üst sınıntan miras alınabilir.
    /// Aşağıda Customer'de olan her şey IndividualCustomer sınıfında da vardır demektir.
    /// </summary>
    class IndividualCustomer:Customer
    {
        public string TcNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}