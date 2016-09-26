using System;

namespace _09_Portfolio
{
    internal class Stock
    {
        private string v1;
        private double v2;
        private int v3;

        public Stock()
        {
        }

        public Stock(string v1, double v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        internal int GetValue()
        {
            throw new NotImplementedException();
        }

        internal static double TotalValue(Stock[] stocks)
        {
            throw new NotImplementedException();
        }

        internal static object TotalValue(Asset[] portfolio)
        {
            throw new NotImplementedException();
        }
    }
}