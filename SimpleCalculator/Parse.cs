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
        public string mathOperator { get; set; }
        public string user_input { get; set; }
        public int[] terms = new int[2];

        public Parse() { }

        public Parse(string input)
        {
            string pattern = "\\s+";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            user_input = rgx.Replace(input, replacement);

            if (CheckForValidInput(user_input))
            {
                GetOperators(user_input);
                GetTerms(user_input);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public char[] ConvertToCharArray()
        {
            return user_input.ToCharArray();
        }

        public void GetOperators(string input)
        {
            string pattern = "[-+*/%]";
            Regex regex = new Regex(pattern);
            Match math_operator = regex.Match(input);

            if (math_operator.Success)
            {
                mathOperator = math_operator.Value;
            }
        }

        public void GetTerms(string input)
        {
            string pattern = @"[-(+*/%)]";

            string[] inputArray = Regex.Split(input, pattern);

            for (int i = 0; i < inputArray.Length; i++)
            {
                terms[i] = Convert.ToInt32(inputArray[i]);
            }
        }

        public bool CheckForValidInput(string input)
        {
            string pattern = @"[0-9]+[(-+*/%)][0-9]+$";
            Regex regex = new Regex(pattern);
            Match expression = regex.Match(input);

            while (expression.Success)
            {
                return true;
            }
            throw new InvalidOperationException();
        }
    }
}
