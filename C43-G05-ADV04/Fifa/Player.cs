using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV04.Fifa
{
    internal class Player
    {
        public string Name {  get; set; }

        public string TeamName { get; set; }

        public void Run(Ball ball)
        {
            Console.WriteLine($"Player {Name} is running at {ball}");
        }
        public override string ToString()
        {
            return $"PlayerName:{Name},TeamName:{TeamName}";
        }
    }
}
