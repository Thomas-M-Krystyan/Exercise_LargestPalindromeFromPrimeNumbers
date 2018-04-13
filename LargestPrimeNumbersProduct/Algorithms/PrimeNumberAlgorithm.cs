using System;

namespace LargestPrimeNumbersProduct.Algorithms
{
    public class PrimeNumberAlgorithm
    {
        #region Fields
        private int _primeBoundaryFormula;
        private int _divisor;
        private int _initDivisor = 3;  // except the most obvious divisors: 0, 1, 2, must be odd!

        private bool _numberIsEven;
        private bool _numberIsDividable;
        #endregion

        public bool IsPrimeNumber(long number)
        {
            switch (number)
            {
                case 0:
                    return false;
                case 1:
                    return false;
                case 2:
                    return true;
            }

            this._numberIsEven = (number % 2).Equals(0);
            if (this._numberIsEven)
            {
                return false;
            }
            
            this._primeBoundaryFormula = (int)Math.Floor(Math.Sqrt(number));

            for (this._divisor = this._initDivisor; this._divisor <= this._primeBoundaryFormula; this._divisor += 2)  // skip testing for even numbers
            {
                this._numberIsDividable = (number % this._divisor).Equals(0);
                if (this._numberIsDividable)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
