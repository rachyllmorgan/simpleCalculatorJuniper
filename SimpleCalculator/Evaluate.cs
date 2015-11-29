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
    public class Evaluate
    {
        public int result { get; set; }
        public int last { get; set; }
        public string lastq { get; set; }
        private string math_expression;

        public Evaluate(Parse parse)
        {
            //CalculateMath(parse);
            parse.user_input = lastq;
            CalculateMath(parse);
        }

        public int CalculateMath(Parse parse)
        {
            int first_term = parse.terms[0];
            int second_term = parse.terms[1];
            math_expression = parse.mathOperator;

            if (math_expression == "+")
            {
                DoAddition(first_term, second_term);
            }
            else if (math_expression == "-")
            {
                DoSubtraction(first_term, second_term);
            }
            else if (math_expression == "/")
            {
                DoDivision(first_term, second_term);
            }
            else if (math_expression == "*")
            {
                DoMultiplication(first_term, second_term);
            }
            else if (math_expression == "%")
            {
                DoModulus(first_term, second_term);
            }
            else
            {
                throw new InvalidOperationException();
            }
            return last;
        }

        public int DoAddition(int first_term, int second_term)
        {
            result = last = first_term + second_term;
            lastq = first_term.ToString() + " + " + second_term.ToString();
            return result;
        }
        public int DoSubtraction(int first_term, int second_term)
        {
            result = last = first_term - second_term;
            lastq = first_term.ToString() + " - " + second_term.ToString();
            return result;
        }
        public int DoDivision(int first_term, int second_term)
        {
            result = last = first_term / second_term;
            lastq = first_term.ToString() + " / " + second_term.ToString();
            return last;
        }
        public int DoMultiplication(int first_term, int second_term)
        {
            result = last = first_term * second_term;
            lastq = first_term.ToString() + " * " + second_term.ToString();
            return result;
        }
        public int DoModulus(int first_term, int second_term)
        {
            result = last = first_term % second_term;
            lastq = first_term.ToString() + " % " + second_term.ToString();
            return result;
        }
    }
}
