using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie7
{
    class TrainingPlan
    {
        private List<ICommand> trainingPlan;
        public TrainingPlan()
        {
            trainingPlan = new List<ICommand>();
        }
        public void Add(ICommand nextStep)
        {
            trainingPlan.Add(nextStep);
        }
        public void StartTraining()
        {
            foreach (ICommand step in trainingPlan)
            {
                step.DoIt();
            }
        }
    }
}
