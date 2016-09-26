using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        private List<Asset> stocks;

        public Portfolio()
        {
        }

        public Portfolio(List<Asset> stocks)
        {
            this.stocks = stocks;
        }

        internal double GetTotalValue()
        {
            throw new NotImplementedException();
        }

        internal void AddAsset(Stock stockHP)
        {
            throw new NotImplementedException();
        }

        internal void AddAsset(SavingsAccount cd1000)
        {
            throw new NotImplementedException();
        }
    }
}