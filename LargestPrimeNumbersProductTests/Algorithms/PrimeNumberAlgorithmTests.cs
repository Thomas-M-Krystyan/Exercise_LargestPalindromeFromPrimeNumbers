using LargestPrimeNumbersProduct.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargestPrimeNumbersProduct.Tests
{
    [TestClass()]
    public class PrimeNumberAlgorithmTests
    {
        private static PrimeNumberAlgorithm _primeNumberAlgorithm;
        private bool _expected;
        private bool _actual;

        [TestInitialize]
        public void Setup()
        {
            // Arrange
            _primeNumberAlgorithm = new PrimeNumberAlgorithm();
        }

        [TestMethod()]
        public void TestPrimeNumbers_IfNumber0_ReturnsFalse()
        {
            // Act
            bool result = _primeNumberAlgorithm.IsPrimeNumber(0);

            // Assert
            this._expected = false;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPrimeNumbers_IfNumber1_ReturnsFalse()
        {
            // Act
            bool result = _primeNumberAlgorithm.IsPrimeNumber(1);

            // Assert
            this._expected = false;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPrimeNumbers_IfNumber2_ReturnsTrue()
        {
            // Act
            bool result = _primeNumberAlgorithm.IsPrimeNumber(2);

            // Assert
            this._expected = true;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPrimeNumbers_IfNumber4_ReturnsFalse()
        {
            // Act
            bool result = _primeNumberAlgorithm.IsPrimeNumber(4);

            // Assert
            this._expected = false;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPrimeNumbers_IfNumber5_ReturnsTrue()
        {
            // Act
            bool result = _primeNumberAlgorithm.IsPrimeNumber(5);

            // Assert
            this._expected = true;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPrimeNumbers_IfLargeNumber99991_ReturnsTrue()
        {
            // Act
            bool result = _primeNumberAlgorithm.IsPrimeNumber(99991);

            // Assert
            this._expected = true;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }

        [TestMethod()]
        public void TestPrimeNumbers_IfLargeNumber99999_ReturnsFalse()
        {
            // Act
            bool result = _primeNumberAlgorithm.IsPrimeNumber(99999);

            // Assert
            this._expected = false;
            this._actual = result;

            Assert.AreEqual(this._expected, this._actual);
        }
    }
}
