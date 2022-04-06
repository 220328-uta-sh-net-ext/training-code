namespace HelloWorld
{
    public class Mathematics
    {
        public static void DataTypes(){
            //declare variable - value type
            int a; // a variable which can hold 4 bytes or 32 bit value, by default its 0
            a = 10; // assigning a value -> stored in stack as it a value type  
           // b=a; // Implicit Type conversion
            Console.WriteLine($"The value of a is {a}");
            string name; // declaring a reference type (by default )
            name="Freddie";
            Console.WriteLine($"The name is Mr. {name}");
        }
        public static void Conversion(){
            int a = 10;  // 4 byte or 32 bit integer 
            double b=10.95; // 8 byte or 64 bit decimal value
            //b=a; // implicit type conversion
            int c;
            //c=(int)b; // casting -> explicit Type conversion
            //c = Convert.ToInt32(b); // another way of type conversion
            string x ="101";
            //x = Convert.ToString(a);  // boxing
            c = Convert.ToInt32(x); // unboxing
            Console.WriteLine($"a - {a} \nb - {b} \nc - {c}");
        }

        public static void Add(){
            Console.Write("Please enter first number ");
            // user input is always in string format
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second number ");
            double num2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1+num2} ");
        }
    }
}