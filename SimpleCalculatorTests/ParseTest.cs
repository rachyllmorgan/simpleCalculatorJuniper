using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System.Collections.Generic;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void ParseEnsureICanCreateAnInstance()
        {
            Parse a_parse = new Parse("21+32");
            Assert.IsNotNull(a_parse);
        }
        [TestMethod]
        public void ParseEnsureICanCreateArrayOfCharactersWithoutSpace()
        {
            Parse a_parse = new Parse("21+32");

            char[] expected = new char[] { '2', '1', '+', '3', '2' }; 
            char[] actual = a_parse.ConvertToCharArray();

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ParseEnsureICanCreateArrayOfCharactersWithSpace()
        {
            Parse a_parse = new Parse("21 + 32");

            char[] expected = new char[] { '2', '1', '+', '3', '2' };
            char[] actual = a_parse.ConvertToCharArray();

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ParseEnsureICanGetOperatorOutOfArray()
        {
            string input = "21+32";
            Parse a_parse = new Parse(input);
            char inputOperator = a_parse.GetOperators(input);

            Assert.AreEqual('+', inputOperator);
        }
        [TestMethod]
        public void ParseEnsureICanGetDigitsOutOfArray()
        {
            Parse a_parse = new Parse();
            string input = "21 + 32";
            int[] expected_terms = new int[] { 21, 32 };
            int[] actual_terms = a_parse.GetTerms(input);

            CollectionAssert.AreEqual(expected_terms, actual_terms);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseEnsureUserEnteredNumberFirst()
        {
            Parse a_parse = new Parse();
            string input = "+31";
            a_parse.CheckForValidInput(input);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseEnsureUserEnteredAnOperator()
        {
            Parse a_parse = new Parse();
            string input = "12431";
            a_parse.CheckForValidInput(input);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseEnsureUserUsesOneOperator()
        {
            Parse a_parse = new Parse();
            string input = "1+/31";
            a_parse.CheckForValidInput(input);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseEnsureUserEndsInputInNumber()
        {
            Parse a_parse = new Parse();
            string input = "23+";
            a_parse.CheckForValidInput(input);
        }
    }
}
