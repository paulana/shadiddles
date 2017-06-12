using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    class ShadiddleMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shadiddles!  Pick your fiddles:");
            Console.WriteLine("Type 'intro' for an overview or 'help' for list of options.");
            string input = Console.ReadLine();
            string[] quit =
            {
                "q",
                "quit",
                "exit",
                "x"
            };

            while (String.IsNullOrWhiteSpace(input) == false && quit.Contains(input.Trim().Split(' ')[0]) == false)
            {
                switch (input.Trim().Split(' ')[0])
                {
                    case "intro":
                        Shadiddle.Demo();
                        break;

                    case "h" :
                    case "help" :
                    case "?" :
                    case "man" :
                        Shadiddle.Help();
                        break;

                    case "list":
                        Shadiddle.Questions(input.Trim().Split(' ')[1]);
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        
    }
}
