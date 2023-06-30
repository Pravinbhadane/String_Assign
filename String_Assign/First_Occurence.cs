using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assign
{
    public class First_Occurence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String ");
            String str = Console.ReadLine();

            Console.WriteLine("Enter a character ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    Console.WriteLine($"First Occurence of character at index no {i}");
                    return;
                }
            }
            Console.WriteLine($"Character not occurs in given String");
        }
    }
}
