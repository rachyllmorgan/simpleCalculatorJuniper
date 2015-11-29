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
            Parse a_parse = new Parse("4 + 2");
            Evaluate eval = new Evaluate(a_parse);
            Assert.IsNotNull(eval);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoAddition()
        {
            Parse a_parse = new Parse("21 + 3");
            Evaluate eval = new Evaluate(a_parse);
            int actual = eval.result;
            Assert.AreEqual(24, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoSubtraction()
        {
            Parse a_parse = new Parse("21 - 3");
            Evaluate eval = new Evaluate(a_parse);
            int actual = eval.result;
            Assert.AreEqual(18, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoDivision()
        {
            Parse a_parse = new Parse("21 / 3");
            Evaluate eval = new Evaluate(a_parse);
            int actual = eval.result;
            Assert.AreEqual(7, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanDoMultiplication()
        {
            Parse a_parse = new Parse("2 * 3");
            Evaluate eval = new Evaluate(a_parse);
            int actual = eval.result;
            Assert.AreEqual(6, actual);
        }
        [TestMethod]
        public void EvaluateEnsureICanGetARemainder()
        {
            Parse a_parse = new Parse("20 % 3");
            Evaluate eval = new Evaluate(a_parse);
            int actual = eval.result;
            Assert.AreEqual(2, actual);
        }
    }
}
