using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Decorator_DP
{
    internal class IDecoratorPlayer : Player
    {
        Player Player { get; set; }
        public IDecoratorPlayer(Player player)
        {
            this.Player = player;
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
