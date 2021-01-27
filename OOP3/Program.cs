using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {//interface, onu implemente eden classın referansını tutabilir
            
            ICreditManager personalFinance = new PersonalFinanceCreditManager();
            ICreditManager vehicle = new VehicleLoanManager();
            ICreditManager realEstate = new RealEstateLoansManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();


            applicationManager.Applicate(new ArtisanCreditManager(),new List<ILoggerService> { databaseLoggerService,new SmsLoggerService()});
            //applicationManager.Applicate(realEstate);
            //applicationManager.Applicate(vehicle);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinance,vehicle };
               // applicationManager.CreditPreInforming(credits);
           

        }
    }
}
