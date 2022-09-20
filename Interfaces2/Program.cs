using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    { // interface new'lenemez
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            
            Console.ReadLine();
        }
        interface IPersonManager
        {
            // unimplemented operation
            void Add();
            void Update();
        }
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                // müşteri ekleme kodları
                Console.WriteLine("Müşteri eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri güncellendi");
            }
        }
        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                // personel ekleme kodları
                Console.WriteLine("Personel eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Personel güncellendi");
            }
        }
        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }
        }
    }
}
