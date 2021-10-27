using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public class StrConvert
    {
        // Takes a string and turns it into an array of chars.
        public static char[] ToChars(string input)
        {
            char[] charArray = new char[input.Length];
            for (int index = 0; index < input.Length; index++)
            {
                charArray[index] = input[index];
            }
            return charArray;
        }

        // Takes a string in the format of a date and returns it as a string array
        public static string[] ToDate(string input)
        {
            return input.Split('/');
        }

        // Takes a string and gives it a telephone format.
        public static string ToPhoneNumber(string input)
        {
            return "(" + input.Substring(0, 3) + ") " + input.Substring(3, 3) + "-" + input.Substring(6, 4);
        }

        public static string ToBackwards(string input)
        {
            string output;

            for (int index = input.Length - 1; index >= 0; index--)
            {
                output[]
            }
            return "";
        }
    }
}
