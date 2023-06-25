using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Strategy_DP
{
    public class Player
    {
        public IGoalStrategy goalStrategy { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public Player(IGoalStrategy goalStrategy,string name):this(name)
        {
            this.goalStrategy = goalStrategy;
        }

        public void SetGoalStrategy(IGoalStrategy goalStrategy)
        {
            this.goalStrategy=goalStrategy;
        }

        public void DisplayPlayerStatus()
        {
            goalStrategy.Score();
        }

    }
}
