namespace LargestPrimeNumbersProduct.Models
{
    public struct Data
    {
        public long StoredResult { get; private set; }
        public long FirstMultiplier { get; private set; }
        public long SecondMultiplier { get; private set; }

        public void Update(long storedResult, long firstMultiplier, long secondMultiplier)
        {
            this.StoredResult = storedResult;
            this.FirstMultiplier = firstMultiplier;
            this.SecondMultiplier = secondMultiplier;
        }
    }
}
