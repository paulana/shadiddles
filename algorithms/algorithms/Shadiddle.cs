using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using algorithms.Fiddles;

namespace algorithms
{
    class Shadiddle
    {
        public static void Demo()
        {
            Palindrome.Demo();
        }

        public static void Help()
        {

        }

        public static void Questions(string list)
        {
            switch (list)
            {
                case "questions":
                    ListQuestions();
                    break;

                case "fiddles":
                    ListFiddles();
                    break;

                case "demos":
                    Demo();
                    break;
            }

        }

        private static void ListQuestions() 
        {

        }

        private static void ListFiddles()
        {

        }
    }
}
