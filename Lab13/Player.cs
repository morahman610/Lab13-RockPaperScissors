using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    abstract class Player
    {
        private string name;
        private Roshambo roshambo;

        protected Player(string name, Roshambo roshambo)
        {
            this.name = name;
            this.roshambo = roshambo;
        }

        public string Name { get => name; set => name = value; }
        public Roshambo Roshambo { get => roshambo; set => roshambo = value; }

        abstract public Roshambo generateRoshambo(string input);
      


    }
}
