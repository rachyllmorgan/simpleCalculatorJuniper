using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;
using System.Text.RegularExpressions;
using System.Data;

namespace SimpleCalculator
{
    public class Evaluate : Parse
    {
        private string math_expression;
        private int result;

        public int CalculateMath(string input)
        {
            Parse a_parse = new Parse();
            string pattern = "[-+*/%]";
            Regex regex = new Regex(pattern);
            Match math_operator = regex.Match(input);

            if (math_operator.Success)
            {
                math_expression = math_operator.Value;
                int[] term_array = a_parse.GetTerms(input);
                int first_term = term_array[0];
                int second_term = term_array[1];

                if (math_expression == "+")
                {
                    result = first_term + second_term;
                }
                else if (math_expression == "-")
                {
                    result = first_term - second_term;
                }
                else if (math_expression == "/")
                {
                    result = first_term / second_term;
                }
                else if (math_expression == "*")
                {
                    result = first_term * second_term;
                }
                else if (math_expression == "%")
                {
                    result = first_term % second_term;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
            return result;
        }
    }
}
