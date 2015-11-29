using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackEnsureICanCreateAnInstance()
        {
            Parse a_parse = new Parse("2 + 3");
            Evaluate eval = new Evaluate(a_parse);
            Stack a_stack = new Stack(eval);

            Assert.IsNotNull(a_stack);
        }
        [TestMethod]
        public void StackEnsureICanGetLastUserInput()
        {
            Parse a_parse = new Parse("21 + 3");
            Evaluate eval = new Evaluate(a_parse);

            Stack a_stack = new Stack(eval);
            string actual_input = a_stack.lastq;

            Assert.AreEqual("21 + 3", actual_input);
        }
        [TestMethod]
        public void StackEnsureICanGetLastUserSolution()
        {
            Parse a_parse = new Parse("21 + 3");
            Evaluate eval = new Evaluate(a_parse);
            int actual = eval.result;
            Assert.AreEqual(24, actual);

            Stack a_stack = new Stack(eval);
            int actual_solution = a_stack.last;

            Assert.AreEqual(24, actual_solution);
        }
    }
}
