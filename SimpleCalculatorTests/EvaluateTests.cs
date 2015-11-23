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
        public void EvaluateEnsureICanGetIntegers()
        {
            Evaluate eval = new Evaluate();
            string input = "21 / 3";
            int[] expected = new int[] { 21, 3 };
            int [] actual = eval.GetTerms(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoAddition()
        {
            Evaluate eval = new Evaluate();
            string input = "21 + 3";
            int actual = eval.CalculateMath(input);
            Assert.AreEqual(24, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoSubtraction()
        {
            Evaluate eval = new Evaluate();
            string input = "21 - 3";
            int actual = eval.CalculateMath(input);
            Assert.AreEqual(18, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoDivision()
        {
            Evaluate eval = new Evaluate();
            string input = "21 / 3";
            int actual = eval.CalculateMath(input);
            Assert.AreEqual(7, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoMultiplication()
        {
            Evaluate eval = new Evaluate();
            string input = "2 * 3";
            int actual = eval.CalculateMath(input);
            Assert.AreEqual(6, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanGetARemainder()
        {
            Evaluate eval = new Evaluate();
            string input = "20 % 3";
            int actual = eval.CalculateMath(input);
            Assert.AreEqual(2, actual);
        }
    }
}
