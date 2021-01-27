using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //method injection, dependencies injection
        public void Applicate(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void CreditPreInforming(List<ICreditManager> credits )
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}
