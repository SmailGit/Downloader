using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventAndDelegateHomeWork.InterfaceForStudent.Clock
{

    //Вывести колличество прошедших секунд в классе Display
    internal class Timer
    {
        public void Start()
        {
            for (int i = 0; i < 100000; i++)
            {
                Thread.Sleep(1000);

            }
        }

    }
}
