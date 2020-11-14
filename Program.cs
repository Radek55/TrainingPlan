using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radosław Bielak\nZadanie 7\nPlan Treningowy\n");

            TrainingPlace swimmingpool = new TrainingPlace("swimming pool");
            TrainingPlace traininggym = new TrainingPlace("training gym");
            RestingPlace jacuzzi = new RestingPlace("jacuzzi");
            RestingPlace sauna = new RestingPlace("sauna");
            //cwiczenia na silowni/basenie poprzedzone rozciaganiem i zakonczone odpoczynkiem
            StretchCommand stretchForGym = new StretchCommand(traininggym, 5);
            TrainingCommand pushups = new TrainingCommand(traininggym, "pushups", 50);
            TrainingCommand situps = new TrainingCommand(traininggym, "situps", 40);
            BreakCommand restAfterGym = new BreakCommand(sauna, 20);
            StretchCommand stretchForPool = new StretchCommand(swimmingpool, 8);
            TrainingCommand diving = new TrainingCommand(swimmingpool, "diving", 5);
            TrainingCommand fastSwimming = new TrainingCommand(swimmingpool, "swimming trought lenght", 10);
            BreakCommand restAfterPool = new BreakCommand(jacuzzi, 10);

            TrainingPlan FirstDay = new TrainingPlan();
            FirstDay.Add(stretchForGym);
            FirstDay.Add(pushups);
            FirstDay.Add(situps);
            FirstDay.Add(restAfterGym);
            FirstDay.Add(stretchForPool);
            FirstDay.Add(diving);
            FirstDay.Add(fastSwimming);
            FirstDay.Add(restAfterPool);
            FirstDay.StartTraining();

            Console.WriteLine("\nDzien drugi\n");
            //zmiana z wykorzystaniem adaptera
            TrainingPlanAdapter SecondDay = new TrainingPlanAdapter();
            SecondDay.Add(stretchForGym,1);
            SecondDay.Add(pushups,2);
            SecondDay.Add(situps,2);
            SecondDay.Add(restAfterGym,1);
            SecondDay.Add(stretchForPool,1);
            SecondDay.Add(diving,2);
            SecondDay.Add(fastSwimming,2);
            SecondDay.Add(restAfterPool,1);
            SecondDay.StartTraining();
        }
    }
}
