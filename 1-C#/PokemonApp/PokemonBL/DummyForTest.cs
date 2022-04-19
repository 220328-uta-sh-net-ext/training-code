namespace PokemonBL
{
    public class DummyForTest
    {
        public double Add(params double[] nums)//params keyword allows to pass any number of inputs as parameters
        {
            double result = 0;
            foreach (var n in nums)
            {
                result += n;
            }
            return result;
        }

        public bool IsOdd(int n)
        {
            return (n % 2 != 0);
        }
    }
}