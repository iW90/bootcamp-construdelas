using System;

namespace DapperAPI.Services
{
    public class Calculation : ICalculation
    {
        public int Calculate(int firstValue, int secondValue)
        {
            if ((firstValue > 99 || secondValue > 99) || (firstValue < 1 || secondValue < 1))
                throw new ArgumentException("Um ou mais valores maior que 99");

            return firstValue + secondValue;
        }
    }
}
