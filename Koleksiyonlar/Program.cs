﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Uğur","Tolga","Emir" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            List<string> isimler2 = new List<string>{"Uğur", "Tolga", "Emir"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Tacettin");
            Console.WriteLine(isimler2[3]);



        }
    }
}
