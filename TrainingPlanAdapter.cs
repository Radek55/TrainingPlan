using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie7
{
    class TrainingPlanAdapter : IOtherCommand
    {
        private List<ICommand> trainingPlan;
        private List<int> dayOfTraining;
        public TrainingPlanAdapter()
        {
            trainingPlan = new List<ICommand>();
            dayOfTraining = new List<int>();
        }
        public void Add(ICommand nextStep, int dayOfTraining) //zmiana ta pozwoli na zwiekszenie ilosci serii danego cwiczenia
        {
            trainingPlan.Add(nextStep);
            this.dayOfTraining.Add(dayOfTraining);
        }
        public void StartTraining()
        {
            for (int j=0; j<trainingPlan.Count; j++)
            {
                for (int i = 0; i < dayOfTraining[j]; i++)
                {
                    trainingPlan[j].DoIt();
                }
            }
        }
    }
}