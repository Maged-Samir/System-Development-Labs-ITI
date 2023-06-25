using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Strategy_DP
{
    public class GoalStrategyByHead : IGoalStrategy
    {
        public void Score()
        {
            Console.WriteLine("Goal Scorred by Head ...");
        }
    }
}
