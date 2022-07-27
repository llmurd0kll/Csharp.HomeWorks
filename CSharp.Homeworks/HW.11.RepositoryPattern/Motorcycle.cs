using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._11.RepositoryPattern
{
    public class Motorcycle
    {
        /// <summary>
        /// Moto ID
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Moto Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Moto Model
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Moto Year
        /// </summary>
        public int Year { get; set;}  

        /// <summary>
        /// Moto Odometr
        /// </summary>
        public int Odometr { get; set; }

        /// <summary>
        /// Method ToString() allows to display info about moto
        /// </summary>
        /// <returns>Moto ID, Name, Model, Year and Odometr</returns>
        public override string ToString()
        {
            return $"Id is {Id}, Name is {Name}, Model is {Model}, Year is {Year}, Odometr is {Odometr}";
        }


    }

    public abstract class BaseEntity : Motorcycle
    {
        public override int Id { get; set; }

        public BaseEntity(int id)
        {
                Id = id;
        }
    }
}