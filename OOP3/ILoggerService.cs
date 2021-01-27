using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //mail gönderme, dosyaya yazma, veritabanına yazma, sms gönderme hepsi bir loglama işlemidir.

    interface ILoggerService
    {
        void Log();
    }
}
