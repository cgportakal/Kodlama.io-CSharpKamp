using System;

namespace G05Eg01OOP2
{
    class OOP2Main
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.CustomerName = "Cafer";
            customer1.CustomerSurname = "Portakal";
            customer1.TcNumber = "1234455666161";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "654655";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "54646123123";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}