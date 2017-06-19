using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algorithms.Fiddles;

namespace algorithms
{
    class ShadiddleMain
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WriteLine("Welcome to Shadiddles!  Pick your fiddles:");
            Console.WriteLine("Type 'intro' for an overview or 'help' for list of options.");
            args = args.Length > 0 ? args : (String.IsNullOrEmpty(Console.ReadLine()) ? new string[0] : Console.ReadLine().Trim().Split(' '));
            
            string[] quit =
            {
                "q",
                "quit",
                "exit",
                "x"
            };

            while (quit.Contains(args[0]) == false)
            {
                switch (args[0])
                {
                    case "intro":
                    case "demo":
                        Shadiddle.Demo();
                        break;

                    case "h" :
                    case "help" :
                    case "?" :
                    case "man" :
                        Shadiddle.Help();
                        break;

                    case "list":
                        Shadiddle.Questions(args[1]);
                        break;

                    default:
                        break;
                }

                args = Console.ReadLine().Split(' ');
            }
        }
    }
}
