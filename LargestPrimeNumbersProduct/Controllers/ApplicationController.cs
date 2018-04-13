using LargestPrimeNumbersProduct.Algorithms;
using LargestPrimeNumbersProduct.Models;
using System.Collections.Generic;

namespace LargestPrimeNumbersProduct.Controllers
{
    public class ApplicationController
    {
        #region Fields
        private static PrimeNumberAlgorithm _primeNumberAlgorithm;
        private static PalindromeAlgorithm _palindromeAlgorithm;
        private static Data _data;

        private long _digitMinimum;  // for 5-digit numbers this will be 10000
        private long _digitMaximum;  // for 5-digit numbers this will be 99999
        private LinkedList<long> _primeNumbersList;
        private long _firstPrimeNumber;
        LinkedListNode<long> _nextNode;
        private long? _nextPrimeNumber;
        private long _secondPrimeNumber;
        private long _primeProduct;

        private bool _primeNumber;
        private bool _palindrome;
        private bool _firstNumberNotExist;
        private bool _productIsLarger;
        #endregion

        static ApplicationController()
        {
            _primeNumberAlgorithm = new PrimeNumberAlgorithm();
            _palindromeAlgorithm = new PalindromeAlgorithm();
            _data = new Data();
        }

        public ApplicationController(long digitMinimum, long digitMaximum)
        {
            this._digitMinimum = digitMinimum;
            this._digitMaximum = digitMaximum;
        }

        /// <summary>
        /// Return the largest possible product of two prime numbers which is a palindrome
        /// </summary>
        public Data GetLargestPrimePalindrome()
        {
            GeneratePrimeNumbersList(this._digitMaximum);

            do
            {
                foreach (var number in this._primeNumbersList)
                {
                    SetPrimeMultipliers(number);
                    SetPrimeProduct();

                    this._palindrome = _palindromeAlgorithm.IsPalindrome(this._primeProduct);
                    if (this._palindrome)
                    {
                        CompareResults();
                    }
                }
                SetupNewSearch();
            } while (this._nextPrimeNumber != null);

            return _data;
        }

        private void GeneratePrimeNumbersList(long initNumber)
        {
            this._primeNumbersList = new LinkedList<long>();

            long currentNumber;
            for (currentNumber = initNumber; currentNumber > this._digitMinimum; currentNumber -= 2)
            {
                this._primeNumber = _primeNumberAlgorithm.IsPrimeNumber(currentNumber);
                if (this._primeNumber)
                {
                    this._primeNumbersList.AddLast(currentNumber);
                }
            }
        }

        private void SetPrimeMultipliers(long number)
        {
            this._firstNumberNotExist = this._firstPrimeNumber.Equals(default(long));
            if (this._firstNumberNotExist)
            {
                this._firstPrimeNumber = number;

                this._nextNode = this._primeNumbersList.Find(number).Next;
                this._nextPrimeNumber = this._nextNode?.Value;
            }

            this._secondPrimeNumber = number;
        }

        private void SetPrimeProduct()
        {
            this._primeProduct = Multiply(this._firstPrimeNumber, this._secondPrimeNumber);
        }

        private static long Multiply(long firstNumber, long secondNumber)
        {
            return checked(firstNumber * secondNumber);
        }

        private void SetupNewSearch()
        {
            this._primeNumbersList.RemoveFirst();
            this._firstPrimeNumber = default(long);
        }

        private void CompareResults()
        {
            this._productIsLarger = this._primeProduct > _data.StoredResult;
            if (this._productIsLarger)
            {
                _data.Update(this._primeProduct, this._firstPrimeNumber, this._secondPrimeNumber);
            }
        }
    }
}
