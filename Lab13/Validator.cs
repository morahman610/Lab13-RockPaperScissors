using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Validator
    {
        //private string InputValidator;

        //public Validator(string inputValidator)
        //{
        //    InputValidator = inputValidator;
        //}

        //public string InputValidator1 { get => InputValidator; set => InputValidator = value; }

        public string ValidateUsersInput ()
        {
            while (true)
            {
                string UserInput = Console.ReadLine();

                if (!(UserInput.ToLower() == "r") && !(UserInput.ToLower() == "a"))
                {
                    Console.WriteLine("That was not a valid input. Please enter 'r' or 'a'.");

                }
                else
                {
                    return UserInput;
                }

            }
        }
    }
}
