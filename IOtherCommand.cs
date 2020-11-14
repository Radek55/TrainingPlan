using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie7
{
    interface IOtherCommand
    {
        void Add(ICommand nextStep, int dayOfTraining);
    }
}
