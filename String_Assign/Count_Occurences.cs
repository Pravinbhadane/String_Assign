using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assign
{
    public class Count_Occurences
    {
     

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String ");
            String str = Console.ReadLine();

            Console.WriteLine("Enter a character ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    count++;
                }
            }
            Console.WriteLine($"Character {character} occurs in given String {count} Times");
        }
    }
}
