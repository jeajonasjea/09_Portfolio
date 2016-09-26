using System;

namespace _09_Portfolio
{
    internal class Asset
    {
        public static implicit operator Asset(SavingsAccount v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Asset(Stock v)
        {
            throw new NotImplementedException();
        }
    }
}