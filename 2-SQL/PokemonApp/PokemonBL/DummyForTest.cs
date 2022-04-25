namespace PokemonBL
{
    /// <summary>
    /// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
    /// What kind of processing? That all depends on the type of functionality you will be doing
    /// It can also hold any computation logic like calculating average, max or min values etc....
    /// </summary>
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
        /*//Anonymous methods - methods with no name, used for 1 time execution
        var IsOddanonymous = delegate (int n) {
            return (n % 2 == 0);
        };

        //Lambda expressions are shorthand notations to Anonymous methods
        var IsOddLamdba = (int n) => n % 2 == 0;*/


        /*double Add(int x, int y)
        {
            return x + y;
        }

        delegate (int x, int y){
            return x+y;
        }

        (x,y) => x+y;*/
    }
}