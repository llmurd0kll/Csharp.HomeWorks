﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    internal class SmallApartment : House
    {
        public override int  Area 
        {           
            get { return base.Area; }
            set { base.Area = value; }
        }
       //public int area = 50;
        public override void ShowData()
        {
            Console.WriteLine($"I'm a smallappartment, my area is {Area} m2");
        }
    }
}
