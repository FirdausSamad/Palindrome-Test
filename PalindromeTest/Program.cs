using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Word:");
            string word = Console.ReadLine();

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            string msg = new string(charArray);
            string message = (string.Equals(word,msg,StringComparison.OrdinalIgnoreCase) )? "Yes . It is palindrome": "No";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
