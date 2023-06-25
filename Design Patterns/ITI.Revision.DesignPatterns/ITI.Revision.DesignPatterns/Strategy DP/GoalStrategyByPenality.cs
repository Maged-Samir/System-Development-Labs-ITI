using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Strategy_DP
{
    public class GoalStrategyByPenality : IGoalStrategy
    {
        public void Score()
        {
            Console.WriteLine("Gola Scored by Penality ...");
        }
    }
}
