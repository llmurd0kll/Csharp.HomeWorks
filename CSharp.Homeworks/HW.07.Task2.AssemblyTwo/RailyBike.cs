using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW._07.Task2.AssemblyOne;

namespace HW._07.Task2.AssemblyTwo
{
    public class RailyBike
    {
        public void PrintState()
        {
            // Ошибка DefaultState - по умолчанию internal, поэтому нет доступа
           // DefaultState defaultState = new DefaultState();
            // Ошибка InternalState - internal, поэтому нет доступа
          // InternalState internalState = new InternalState();

            // норм, PublicState - public, доступен из других программ
            PublicState publicState = new PublicState();
            // Ошибка, нет доступа - метод доступен только в свой сборке
           // publicState.PrintInternal();
            // Ошибка, нет доступа - метод доступен только в свой сборке
           // publicState.PrintProtectedInternal();  // нет доступа
            // норм - общедоступный метод
            publicState.PrintPublic();      // норм
        }
    }
}
