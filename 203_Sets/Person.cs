using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Set_T_
{
    internal class Person
    {
        string name = "X";
        int age = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age;

        public static void Print(string name, string surname)
        {
            Console.WriteLine($"{name}");
        }

        public string putName(string name)
        {
           return this.Name = name;
        }
    }
}
