using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg02OOP3
{
    /// <summary>
    /// Müşteri Kredisi Manager'ı
    /// </summary>
    class ConsumerCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
