using System;
using System.Collections.Generic;
using System.Text;

namespace G05Eg02OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
