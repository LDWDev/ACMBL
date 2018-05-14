using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(string source)
        {
            //string source = "IAm TestingThisString:ModelAa";
            string pattern = @"(?<=\S)[A-Z]"; //matches capital letters that are not the first character in a string or that follow whitespace
            string replacement = @" $0"; //replaces the match with whitespace + match
            string result = Regex.Replace(source, pattern, replacement); //runs the replacer on the source string
        //result ="I Am Testing This String: Model A"
            return result; //returns result
        }
    }
}
