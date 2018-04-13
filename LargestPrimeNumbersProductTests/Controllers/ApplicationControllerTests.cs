using LargestPrimeNumbersProduct.Algorithms;
using LargestPrimeNumbersProduct.Controllers;
using LargestPrimeNumbersProduct.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LargestPrimeNumbersProduct.Tests
{
    [TestClass()]
    public class ApplicationControllerTests
    {
        private ApplicationController _application;
        private Data _data;

        [TestInitialize]
        public void Setup()
        {
            // Arrange
            this._application = new ApplicationController(10000, 99999);
        }

        [TestMethod]
        public void TestApplication_IfNumber99999_Returns3FieldsStruct()
        {
            // Act
            this._data = this._application.GetLargestPrimePalindrome();
            IList<long> dataList = new List<long>() { this._data.StoredResult,
                                                      this._data.FirstMultiplier,
                                                      this._data.SecondMultiplier };
            // Assert
            const long notExpected = default(long);

            foreach (var data in dataList)
            {
                Assert.AreNotEqual(notExpected, data);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestApplication_IfNumber0_ThrowsException()
        {
            // Arrange
            this._application = new ApplicationController(10000, 0);

            // Act
            this._application.GetLargestPrimePalindrome();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestApplication_IfNumberNegative99999_ThrowsException()
        {
            // Arrange
            this._application = new ApplicationController(10000, -99999);

            // Act
            this._application.GetLargestPrimePalindrome();
        }

        [TestMethod]
        public void TestApplication_IfNumber99999_ReturnsPalindromeProduct()
        {
            // Arrange
            PalindromeAlgorithm palindromeAlgorithm = new PalindromeAlgorithm();

            // Act
            this._data = this._application.GetLargestPrimePalindrome();
            long product = this._data.StoredResult;

            // Assert
            const bool expected = true;
            bool actual = palindromeAlgorithm.IsPalindrome(product);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestApplication_IfNumber99999_ReturnsProductOfMultiplication()
        {
            // Act
            this._data = this._application.GetLargestPrimePalindrome();

            long product = this._data.StoredResult;
            long firstMultiplier = this._data.FirstMultiplier;
            long secondMultiplier = this._data.SecondMultiplier;

            long result = product / firstMultiplier;

            // Assert
            long expected = secondMultiplier;
            long actual = result;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestApplication_IfNumber99999_ReturnsTwoPrimeMultipliers()
        {
            // Arrange
            PrimeNumberAlgorithm primeNumberAlgorithm = new PrimeNumberAlgorithm();

            // Act
            this._data = this._application.GetLargestPrimePalindrome();
            IList<long> multipliersList = new List<long>() { this._data.FirstMultiplier, this._data.SecondMultiplier };

            // Assert
            const bool expected = true;
            bool actual;

            int resultLength = multipliersList.Count - 1;

            for (int index = 1; index < resultLength; index++)
            {
                actual = primeNumberAlgorithm.IsPrimeNumber(multipliersList[index]);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
