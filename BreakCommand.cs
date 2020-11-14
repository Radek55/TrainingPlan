using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie7
{
    class BreakCommand : ICommand
    {
        public RestingPlace ActivityPlace { get; set; } //miejsce odpoczynku
        private int BreakTime { get; set; }
        public BreakCommand(RestingPlace aP, int bT)
        {
            ActivityPlace = aP;
            BreakTime = bT;
        }
        public void DoIt()
        {
            Console.WriteLine(BreakTime + " minutes break at "+ActivityPlace.ActivityPlace);
        }
    }
}
