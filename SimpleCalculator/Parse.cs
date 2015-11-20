using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parse
    {
        private char mathOperator;
        private string value;
        private string[] string_expression = new string[3];
        private int [] int_expression = new int[3];

        public Parse(string input)
        {
            string pattern = "\\s+";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            value = rgx.Replace(input, replacement);
        }

        public Parse()
        {
        }


        public char [] ConvertToCharArray()
        {
            return value.ToCharArray();
        }

        public char GetOperators(string input)
        {
            Parse a_parse = new Parse(input);
            char [] inputArray = a_parse.ConvertToCharArray();
            foreach(char letter in inputArray)
            {
                if(letter == '+' || letter == '-' || letter == '*' || letter == '/' || letter == '%')
                {
                    mathOperator = letter;
                    string_expression[1] = mathOperator.ToString();

                }
            }
            return mathOperator;
        }

        public int[] GetTerms(string input)
        {
            int[] terms = new int[2];
            string pattern = @"[(-+*/)]";
            //Regex regex = new Regex(pattern);

            string[] inputArray = Regex.Split(input, pattern);

            for (int i = 0; i < inputArray.Length; i++)
            {
                terms[i] = Convert.ToInt32(inputArray[i]);
            }
            return terms;
        }

        public bool CheckForValidInput(string input)
        {
            return false;
        }
    }
}
