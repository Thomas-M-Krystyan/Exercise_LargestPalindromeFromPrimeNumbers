using LargestPrimeNumbersProduct.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargestPrimeNumbersProduct.Tests
{
    [TestClass()]
    public class PalindromeAlgorithmTests
    {
        private static PalindromeAlgorithm _palindromeAlgorithm;
        private bool _expected;
        private bool _actual;

        [TestInitialize]
        public void Setup()
        {
            // Arrange
            _palindromeAlgorithm = new PalindromeAlgorithm();
        }

        [TestMethod()]
        public void TestPalindrome_IfNumber1234554321_ReturnsTrue()
        {
            // Act
            bool result = _palindromeAlgorithm.IsPalindrome(1234554321);

            // Assert
            this._expected = true;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPalindrome_IfNumber123454321_ReturnsTrue()
        {
            // Act
            bool result = _palindromeAlgorithm.IsPalindrome(123454321);

            // Assert
            this._expected = true;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPalindrome_IfNumber12345_ReturnsFalse()
        {
            // Act
            bool result = _palindromeAlgorithm.IsPalindrome(12345);

            // Assert
            this._expected = false;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPalindrome_IfSingleDigit_ReturnsTrue()
        {
            // Act
            bool result = _palindromeAlgorithm.IsPalindrome(0);

            // Assert
            this._expected = true;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }
    }
}
