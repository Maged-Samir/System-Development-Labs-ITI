using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.DesignPatterns.Adapter_DP
{
    internal interface Player
    {
        public int ID { get; set; }
        public string? FullName { get; set; }
        
        public static void DisplayDetails(Player player)
        {
            Console.WriteLine($"Player Id :{player.ID} - {player.FullName}");
        }
    }
}
