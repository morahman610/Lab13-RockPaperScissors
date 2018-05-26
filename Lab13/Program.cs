using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Roshambo.");

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            

            Console.WriteLine("Would you like to play against The Rock or AI?(r/a) Enter No to quit.");

            Validator opponentValidator = new Validator();

            string playerChosen = opponentValidator.ValidateUsersInput();



           
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Rock, Paper, or Scissors?");
                string myInput = Console.ReadLine();



                RoshamboApp opponent = new RoshamboApp(playerChosen);
                //
                String  output = opponent.ChoosAPlayer(playerChosen);
                Console.WriteLine("Opponent chooses:" + output);

                if (myInput.ToLower() == "scissors")
                {
                    if (output == "Rock")
                    {
                        Console.WriteLine("You Lose :(");
                    }
                    else if (output == "Paper")
                    {
                        Console.WriteLine("You Win!");
                    }
                    else if (output == "Scissors")
                    {
                        Console.WriteLine("Draw!");
                    }
                }
                else
                {
                    if (myInput.CompareTo(output) == 0)
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (myInput.CompareTo(output) > 0)
                    {
                        Console.WriteLine("You Lose :(");
                    }
                    else if (myInput.CompareTo(output) < 0)
                    {
                        Console.WriteLine("You Win!");
                    }
                    else if (output.CompareTo(myInput) == 0)
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (output.CompareTo(myInput) < 0)
                    {
                        Console.WriteLine("You Win!");
                    }
                    else if (output.CompareTo(myInput) > 0)
                    {
                        Console.WriteLine("You lose!");
                    } 
                }


                Console.WriteLine("Play again? (y/n)");
                string playAgain = Console.ReadLine();
                if(playAgain == "n")
                {
                    keepGoing = false;
                }
                else
                {
                    keepGoing = true;
                }



            }

           // Console.WriteLine("Your opponent: " + opponent.ChoosAPlayer(playerChosen));
            Console.WriteLine("TY");


            



            

        }
    }
}
