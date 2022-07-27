using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    internal class Student : Person
    {
        string message = "I’m going to class";

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }

        public void GoToClasses()
        {
            Console.WriteLine(message);
        }

        public void Greet()
        {
            SayHello();
            ShowAge();
        }
    }
}
