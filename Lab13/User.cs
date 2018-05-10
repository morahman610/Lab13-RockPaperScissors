using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class User : Player
    {
       

        public User(string name, Roshambo roshambo) : base(name, roshambo)
        {
            this.Name = name;
            this.Roshambo = Roshambo;
        }

        public override Roshambo generateRoshambo(string input)
        {
            while (true)
            {
                if (input == "rock")
                {
                    return Roshambo.Rock;
                }
                else if (input == "paper")
                {
                    return Roshambo.Paper;
                }
                else if (input == "scissors")
                {
                    return Roshambo.Scissors;
                } 
            }

        }
    }
}
