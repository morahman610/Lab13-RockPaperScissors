using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class theRock : Player
    {
        public theRock (string Name, Roshambo Roshambo) : base (Name, Roshambo)
        {

        }

        public override Roshambo generateRoshambo(string input)
        {
            return Roshambo.Rock;
        }
    }
}
