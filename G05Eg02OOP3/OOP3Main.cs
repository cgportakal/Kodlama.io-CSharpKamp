using System;
using System.Collections.Generic;

namespace G05Eg02OOP3
{
    class OOP3Main
    {
        static void Main(string[] args)
        {
            //Farklı kredi türlerinin hesaplanma işlemleri
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager craftCreditManager = new CraftCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService()};

            RequestManager requestManager = new RequestManager();
            requestManager.MakeRequest(new MortgageCreditManager(), loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { consumerCreditManager, vehicleCreditManager};
            //requestManager.KrediOnBilgilendirmesiYap(credits);

        }
    }
}
