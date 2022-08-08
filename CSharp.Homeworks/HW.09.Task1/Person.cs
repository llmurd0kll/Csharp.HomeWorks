using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    internal class Person
    {
       public int age = 20;

        public void SetAge(int age1)
        {
            age = age1;
        }
        
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
