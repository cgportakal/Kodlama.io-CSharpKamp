using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg02OOP3
{
    class CraftCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
