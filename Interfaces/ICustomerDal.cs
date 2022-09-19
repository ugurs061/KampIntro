using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal// Dal (Data access layer) veri tabanı işlemlerini yapacağımız sınıflarda kullanılır.
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql uptaded");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Orecle added");
        }

        public void Delete()
        {
            Console.WriteLine("Orecle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Orecle uptaded");
        }
        
        
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql uptaded");
        }
    }
        class CustomerManager
        {
            public void Add(ICustomerDal customer)
            {
                customer.Add();
            }
        }
    }
