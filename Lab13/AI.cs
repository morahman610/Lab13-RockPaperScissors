using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class AI : Player
    {
        private Roshambo paper;
        private Roshambo scissors;
        public Roshambo Paper { get => Paper; set => Paper = value; }
        public Roshambo Scissors { get => Scissors; set => Scissors = value; }


        public AI(string name, Roshambo Roshambo, Roshambo paper, Roshambo scissors) : base(name, Roshambo)
        {
            this.paper = paper;
            this.scissors = scissors;
        }

        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) 
            {
                return getrandom.Next(min, max);
            }
        }

        public override Roshambo generateRoshambo(string input)
        {
            int randomNumber = GetRandomNumber(1, 3);

            if (randomNumber == 1)
            {
                return Roshambo.Rock;
            }
            else if (randomNumber == 2)
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }
            
        }
    }
}
