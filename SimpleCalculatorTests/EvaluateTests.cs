using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateEnsureICanCreateAnInstance()
        {
            Evaluate eval = new Evaluate();
            Assert.IsNotNull(eval);
        }
        [TestMethod]
        public void EvaluateCanDetermineMathOperator()
        {
            Evaluate eval = new Evaluate();
            string input = "21-3";

            char result = eval.DetermineEvaluator(input);

            Assert.AreEqual('-', result);
        }
        [TestMethod]
        public void EvaluateCanHandleAddition()
        {
            Evaluate eval = new Evaluate();
            string input = "32 + 12";

            int result = eval.Addition(input);

            Assert.AreEqual(44, result);
        }
    }
}
