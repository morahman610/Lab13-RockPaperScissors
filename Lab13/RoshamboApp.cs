using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RoshamboApp
    {
        private string playerOption;

        public RoshamboApp(string playerOption)
        {
            this.playerOption = playerOption;
        }

        public string PlayerOption { get => playerOption; set => playerOption = value; }

        public string ChoosAPlayer(string playerChosen)
        {
            while (true)
            {


                if (playerChosen.ToLower() == "r")
                {
                    theRock rock = new theRock("the Rock", Roshambo.Rock);
                    return rock.generateRoshambo("r").ToString();
                    
                    
                }
                else if (playerChosen.ToLower() == "a")
                {

                    AI randomOutput = new AI("AI", Roshambo.Rock, Roshambo.Paper, Roshambo.Scissors);

                    
                    return randomOutput.generateRoshambo("a").ToString();


                }
                else if (playerChosen.ToLower() == "quit")
                {
                    return " ";
                }
                else
                {
                    Console.WriteLine("That was an invalid input. Please try again.");
                } 
            }

        }
    }

    
}
