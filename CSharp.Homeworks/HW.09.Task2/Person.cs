using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class Person : SmallApartment
    {
       public string name = "Anna";
        public House house = new House();
        
        public void ShowData()
        {
            Console.WriteLine($"My name is {name}");
            house.ShowData();
            house.GetDoor();
        }
    }
}
