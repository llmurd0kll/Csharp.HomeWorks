using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    public class House
    {
        public int area;
        Door door = new Door();

        public virtual int Area
        {
            get { return area; }
            set { area = value; }
        }

        public House()
        {
            area = 200;
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"I'm a house, my area is {area} m2");
        }
        public void GetDoor()
        {
           door.ShowData();
        }
    }
}
