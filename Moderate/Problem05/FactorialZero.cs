namespace Moderate.Problem05
{
    public class FactorialZeros
    {
        public int FindZeros(int number)
        {
            int numberOfZeroes = 0;

            for (int i = 5; number/i >= 1; i *= 5)
            {
                numberOfZeroes += number / i;
            }

            return numberOfZeroes;
        }
    }
}
