using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assign
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentence ");
            String sentence1 = Console.ReadLine();

            bool isPalindrome  = IsPalindrome(sentence1);

            if(isPalindrome)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome");
            }

        }
        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
