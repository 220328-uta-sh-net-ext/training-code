class Program
{
    static void Main()
    {
        Method(Utilities.GlobalValue);
    }

    static void Method(int neededValue)
    {
        int i;
        int b = neededValue, a = 32;
        for (i = 0; i <= 10; i++)
        {
            if ((a / b * 2) == 2)
                Console.Write(i + " ");
            else if (i != 4)
                Console.Write(i + " ");
            else
                break;
        }
    }
}

public static class Utilities
{
    public const int GlobalValue = 4;
}
