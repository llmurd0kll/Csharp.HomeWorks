using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._11.RepositoryPattern
{
    public interface IMotorcycleRepository
    {
        /// <summary>
        /// Interface GetMotorcycleByID() implements GetMotorcycleByID method in MotorcycleRepository
        /// </summary>
        void GetMotorcycleByID();

        /// <summary>
        /// Interface GetMotorcycles() implements GetMotorcycles method in MotorcycleRepository
        /// </summary>
        void GetMotorcycles();

        /// <summary>
        /// Interface CreateMotorcycle() implements CreateMotorcycle method in MotorcycleRepository
        /// </summary>
        void CreateMotorcycle();

        /// <summary>
        /// Interface UpdateMotorcycle() implements UpdateMotorcycle method in MotorcycleRepository
        /// </summary>
        void UpdateMotorcycle();

        /// <summary>
        /// Interface DeleteMotorcycle() implements DeleteMotorcycle method in MotorcycleRepository
        /// </summary>
        void DeleteMotorcycle();
    }
}