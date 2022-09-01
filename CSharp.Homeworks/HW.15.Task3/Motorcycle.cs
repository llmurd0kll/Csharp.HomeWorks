using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._15.Task3
{
    internal class Motorcycle
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public DateTime CreatedAt { get; set; }

        private int _vinNumber = 111;

        private int _odometer;

        public int Odometer { get => _odometer; set => _odometer = value; }

        public Motorcycle()
        {
        }
        public Motorcycle(string name)
        {
            Name = name;
        }
        public Motorcycle(DateTime created, string name)
        {
        }

        public int GetVinNumber()
        {
            return _vinNumber;
        }

        public override string ToString()
        {
            return $"Motorcycle: {Name}, Model: {Model}, Odometer: {Odometer}, VinNumber: {GetVinNumber()}";
        }
    }
}
