namespace LargestPrimeNumbersProduct.Algorithms
{
    public class PalindromeAlgorithm
    {
        #region Fields
        private string _stringNumber;
        private int _stringNumberLength;
        private int _lastIndex;
        private int _halvedLength;

        private bool _singleDigitNumber;
        #endregion

        public bool IsPalindrome(long number)
        {
            this._stringNumber = number.ToString();
            this._stringNumberLength = this._stringNumber.Length;

            this._singleDigitNumber = this._stringNumberLength.Equals(1);
            if (this._singleDigitNumber)
            {
                return true;
            }

            this._lastIndex = this._stringNumberLength - 1;
            this._halvedLength = this._lastIndex / 2;

            for (int index = 0; index <= this._halvedLength; index++)
            {
                if (this._stringNumber[index] != this._stringNumber[this._lastIndex - index])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
