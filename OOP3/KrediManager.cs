using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // her kredi tipi için farklı hesaplamalar yapılacağı için interface kullanıyoruz.
    // interfaceleri birbirinin alternatifi olan ama kod içeriği biribirinden farklı olan durumlar için kullanırız.
    interface IKrediManager 
    {
        void Hesapla();
        void BiseyYap();
        
        
        
    }
}
