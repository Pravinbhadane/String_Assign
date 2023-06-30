using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assign
{
    public class Trim_Whitespaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String ");

            String str = Console.ReadLine();

            string trimmedResult = str.Trim();

            Console.WriteLine("Trimmed string: " + trimmedResult);
        }
    }
}
