// See https://aka.ms/new-console-template for more information

class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        //Func delegate
        Func<int, int, int> add = Sum;

        int result = add(10, 10);

        Console.WriteLine(result);
    }
}