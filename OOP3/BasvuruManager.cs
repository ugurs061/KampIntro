using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) // tek bir krediyi hesaplar ve birden fazla loglama için list kullanırız.
        {
            //başvuan biligilerini değerlendirme
            //

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)// birden fazla krediyi aynı anda hesaplamak için list kullandık.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
