using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "IAm TestingThisString:ModelAa";
            string pattern = @"(?<=\S)[A-Z]";
            string replacement = @" $0";
            string result = Regex.Replace(source, pattern, replacement);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
