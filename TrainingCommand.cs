using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie7
{
    class TrainingCommand : ICommand
    {
        public TrainingPlace ActivityPlace { get; set; } //miejsce cwiczen
        public string ActivityName { get; set; } //nazwa cwiczenia
        public int ActivityRepeats { get; set; } //ilosc powtorzen
        public TrainingCommand(TrainingPlace aP, string aN, int aR)
        {
            ActivityPlace = aP;
            ActivityName = aN;
            ActivityRepeats = aR;
        }
        public void DoIt()
        {
            Console.WriteLine(ActivityRepeats+" repeats of "+ActivityName+" on "+ActivityPlace.ActivityPlace);
        }
    }
}
