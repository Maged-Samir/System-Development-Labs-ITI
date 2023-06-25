using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Decorator_DP
{
    internal class GoalKeeper : IDecoratorPlayer ,Player
    {
        public GoalKeeper(Player player) : base(player)
        {
        }

        public void Play()
        {
            Console.WriteLine("i'am a goal keeper ...");
        }
    }
}
