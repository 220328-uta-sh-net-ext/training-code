namespace HelloWorld
{
    public class Mathematics
    {
        public static void DataTypes()
        {
            //declare variable - value type
            int a; // a variable which can hold 4 bytes or 32 bit value, by default its 0
            a = 10; // assigning a value -> stored in stack as it a value type  
                    // b=a; // Implicit Type conversion
            Console.WriteLine($"The value of a is {a}");
            string name; // declaring a reference type (by default )

            name = "Freddie";
            Console.WriteLine($"The name is Mr. {name}");
        }
        public static void Conversion()
        {
            int a = 10;  // 4 byte or 32 bit integer 
            double b = 10.95; // 8 byte or 64 bit decimal value
            //b=a; // implicit type conversion
            int c;
            //c=(int)b; // casting -> explicit Type conversion
            //c = Convert.ToInt32(b); // another way of type conversion
            string x = "101";
            //x = Convert.ToString(a);  // boxing
            c = Convert.ToInt32(x); // unboxing
            Console.WriteLine($"a - {a} \nb - {b} \nc - {c}");
        }
        public static void Add()
        {
        input1:
            Console.Write("Please enter first number ");
            var input1 = Console.ReadLine();
            // user input is always in string format
            double num1, num2;
            bool input1Success = double.TryParse(input1, out num1);
            while (!input1Success)
            {
                Console.WriteLine("Invalid number!! try again...");
                goto input1;
            }
        input2:
            Console.Write("Please enter second number ");
            var input2 = Console.ReadLine();
            bool input2Success = double.TryParse(input2, out num2);
            while (!input2Success)
            {
                Console.WriteLine("Invalid number!! try again...");
                goto input2;
            }
            Console.WriteLine($"{num1} + {num2} = {num1 + num2} ");
        }
    }
}