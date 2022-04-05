namespace HelloWorld
{
    public class Mathematics
    {
        public static void DataTypes(){
            //declare variable - value type
            int a; // a variable which can hold 4 bytes or 32 bit value, by default its 0
            a = 10; // assigning a value -> stored in stack as it a value type
            Console.WriteLine($"The value of a is {a}");
            string name; // declaring a reference type (by default )
            name="Freddie";
            Console.WriteLine($"The name is Mr. {name}");
        }
    }
}