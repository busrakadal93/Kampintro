using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        //veritabanına loglama yapacak servis
        //ILoggerService den miras alıncak
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");        
        }
    }
}
