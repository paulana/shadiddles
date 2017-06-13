using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.Fiddles
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            bool palindrome = true;
            int i;
            int k;
            string input = word.ToLower().Replace(" ", String.Empty).Replace();
            for (i = 0; i < input.Length; i++)
            {
                for (k = input.Length - 1 - (1*i); k > i; k--)
                {
                    if (input.ElementAt(i) != input.ElementAt(k))
                    {
                        palindrome = false;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return palindrome;
        }

        public static void ViewExamples()
        {
            Console.WriteLine("\nDeleveled");
            Console.WriteLine("Palindrome?: " + Palindrome.IsPalindrome("Deleveled"));
            Console.WriteLine("\nRacecar");
            Console.WriteLine("Palindrome?: " + Palindrome.IsPalindrome("Racecar"));
            Console.WriteLine("\nDeleveled");
            Console.WriteLine("Palindrome?: " + Palindrome.IsPalindrome("Deleveled"));
            Console.WriteLine("\nDeleveled");
            Console.WriteLine("Palindrome?: " + Palindrome.IsPalindrome("Deleveled"));
            Console.WriteLine("\nDeleveled");
            Console.WriteLine("Palindrome?: " + Palindrome.IsPalindrome("Deleveled"));
            Console.WriteLine("\nDeleveled");
            Console.WriteLine("Palindrome?: " + Palindrome.IsPalindrome("Deleveled"));
        }

        public static void ViewCode()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("public static bool IsPalindrome(string word)");
            Console.ResetColor();
            Console.WriteLine("\t{");
            Console.WriteLine("\t\tbool palindrome = true;");
            Console.WriteLine("\t\tint i;");
            Console.WriteLine("\t\tint k;");
            Console.WriteLine("\t\tfor (i = 0; i < word.Length; i++)");
            Console.WriteLine("\t\t{");
            Console.WriteLine("\t\t\tfor (k = word.Length - 1 - (1*i); k > i; k--)");
            Console.WriteLine("\t\t\t{");
            Console.WriteLine("\t\t\t\tif (word.ToLower().ElementAt(i) != word.ToLower().ElementAt(k))");
            Console.WriteLine("\t\t\t\t\tpalindrome = false;");
            Console.WriteLine("\t\t\t\telse");
            Console.WriteLine("\t\t\t\t\tbreak;");
            Console.WriteLine("\t\t\t}");
            Console.WriteLine("\t\t}");
            Console.WriteLine("\treturn palindrome;");
            Console.WriteLine("}");
        }
    }

}
