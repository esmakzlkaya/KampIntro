using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esma Kızılkaya 

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Esma";
            customer1.Surname = "Kızılkaya";
            customer1.TcNumber = "11111111111";


            //Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "123456789";

            //Gerçek - Tüzel birbirinin yerine 
            //kullanılamaz ihtiyaçları ve özellikleri
            //farklıdır.
            ///SOLID
            ///


            //Customer classı hem gerçek müşterinin hem de
            //tüzel müşterinin referansını tutabiliyor.
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}
