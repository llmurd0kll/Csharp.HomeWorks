using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._12.PayrollSystem
{
    internal interface IEngineerRepository
    {
        void CreateEngineer();

        void ViewAllEngineers();

        void UpdateEngineer();

        void DeleteEngineer();
    }
}
