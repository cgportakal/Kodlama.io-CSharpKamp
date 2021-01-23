using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg02OOP3
{
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
