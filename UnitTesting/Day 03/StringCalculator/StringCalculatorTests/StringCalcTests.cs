using StringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTests
{
    [TestClass]
    public class StringCalcTests
    {
        #region V1
        //[TestMethod]
        //public void TestAdd()
        //{
        //    StringCalc calculator = new StringCalc();

        //    int result = 0;
        //    string numbers = "";

        //    // Test case for empty string
        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(0, result);
        //    }
        //}
        #endregion

        #region V2
        //[TestMethod]
        //public void TestAdd()
        //{
        //    StringCalc calculator = new StringCalc();

        //    int result = 0;
        //    string numbers = "";

        //    // Test case for empty string
        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(0, result);
        //    }

        //    // Test case for single number
        //    numbers = "1";
        //    if (!string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(1, result);
        //    }
        //}
        #endregion

        #region V3
        //[TestMethod]
        //public void TestAdd()
        //{
        //    StringCalc calculator = new StringCalc();

        //    int result = 0;
        //    string numbers = "";

        //    // Test case for empty string
        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(0, result);
        //    }

        //    // Test case for single number
        //    numbers = "1";
        //    if (!string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(1, result);
        //    }

        //    // Test case for two numbers
        //    numbers = "1,2";
        //    if (!string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(3, result);
        //    }

        //}
        #endregion

        #region V4
        //[TestMethod]
        //public void TestAdd()
        //{
        //    StringCalc calculator = new StringCalc();

        //    int result = 0;
        //    string numbers = "";

        //    // Test case for empty string
        //    if (string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(0, result);
        //    }

        //    // Test case for single number
        //    numbers = "1";
        //    if (!string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(1, result);
        //    }

        //    // Test case for two numbers separated by commas
        //    numbers = "1,2";
        //    if (!string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(3, result);
        //    }

        //    // Test case for unknown number of numbers separated by commas or new lines
        //    numbers = "1\n2,3";
        //    if (!string.IsNullOrEmpty(numbers))
        //    {
        //        result = calculator.Add(numbers);
        //        Assert.AreEqual(6, result);
        //    }

        //}
        #endregion

        #region V5
        [TestMethod]
        public void TestAdd()
        {
            StringCalc calculator = new StringCalc();

            int result = 0;
            string numbers = "";

            // Test case for empty string
            if (string.IsNullOrEmpty(numbers))
            {
                result = calculator.Add(numbers);
                Assert.AreEqual(0, result);
            }

            // Test case for single number
            numbers = "1";
            if (!string.IsNullOrEmpty(numbers))
            {
                result = calculator.Add(numbers);
                Assert.AreEqual(1, result);
            }

            // Test case for two numbers separated by commas
            numbers = "1,2";
            if (!string.IsNullOrEmpty(numbers))
            {
                result = calculator.Add(numbers);
                Assert.AreEqual(3, result);
            }

            // Test case for unknown number of numbers separated by commas or new lines
            numbers = "1\n2,3";
            if (!string.IsNullOrEmpty(numbers))
            {
                result = calculator.Add(numbers);
                Assert.AreEqual(6, result);
            }

            try
            {
                result = calculator.Add("-1");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("negatives not allowed: -1", ex.Message);
            }

            try
            {
                result = calculator.Add("-1,-2,3,-4");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("negatives not allowed: -1, -2, -4", ex.Message);
            }

        }
        #endregion

    }
}
