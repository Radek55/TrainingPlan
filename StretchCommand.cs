using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie7
{
    class StretchCommand : ICommand
    {
        public TrainingPlace StretchingPlace { get; set; }
        public int StretchingTime { get; set; }
        public StretchCommand(TrainingPlace sP, int sT)
        {
            StretchingPlace = sP;
            StretchingTime = sT;
        }
        public void DoIt()
        {
            Console.WriteLine(StretchingTime+" minutes of stretching on "+StretchingPlace.ActivityPlace);
        }
    }
}
