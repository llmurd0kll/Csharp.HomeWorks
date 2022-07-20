using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    internal class Hotel
    {
        public string[] Name { get; set; }
        public string Address { get; set; }
        public int Rate { get; set; }

        public void Search()
        {

        }

        public void Book()
        {
            Console.WriteLine("Please enter the name of the hotel you would like to book in: ");
            string userInput = Console.ReadLine();
            userInput.ToCharArray();
          
            for (int i = 0; i<=Name.Length; i++)
            {
                
                if (Name.Equals(userInput))
                {

                }
            }
        }

        public void Purchase()
        {

        }
    }
}
