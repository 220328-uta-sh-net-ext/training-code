namespace CSharpBasics
{
    public class CSharpArrays
    {
        public static void Arrays_1D()
        {
            int[] scores; //delcare an array
            scores = new int[5]; // initializing of an array -> this will assign a 20 bytes memory block
            //insert elements
            scores[0] = 50;
            scores[3] = 78;

            //read an element of an array
            //Console.WriteLine(scores[1]); // reading 1 value at a time
            Console.WriteLine($"Size of an array = {scores.Length}");
            Console.WriteLine($"Dimension of the array = {scores.Rank}");
            // read entire array backwards
            /*for (int i = scores.Length-1; i >= 0 ; i--)
            {
                Console.Write(scores[i]+ " ");
            }*/
            Array.Reverse(scores);
            foreach (var score in scores)
            {
                Console.Write(score + " ");
            }
        }

        public static void Arrays_MultiDimensional()
        {
            int[,] twoDArray = new int[2, 3]; // 2D array with 2 rows and 3 columns
            int[,,] threeDArray = new int[3, 3, 3];//3D Array
            Console.WriteLine($"Size = {twoDArray.Length}");
            Console.WriteLine($"Rank = {twoDArray.Rank}");

            twoDArray[0, 0] = 1;
            twoDArray[1, 0] = 2;

            //read an element
            //Console.WriteLine(twoDArray[1,2]);

            /*for (int i = 0; i < 2; i++)  // rows
            {
                for (int j = 0; j < 3; j++) // columns
                {
                    Console.Write(twoDArray[i,j]+ " ");
                }
                Console.WriteLine();
            }*/

            foreach (var element in twoDArray)
            {
                Console.Write(element + " ");
            }
        }

        public static void JaggedArrays()
        {
            int[][] jaggedArray = new int[2][]; // only initialize rows during declaration
            jaggedArray[0] =  new int[3]; // intializing columns for 1st row; 1st row has 3 columns
            jaggedArray[1] = new int[5]; // initializing columsn for 2nd row; 2nd row has 5 columns 
            //1st rows 
            jaggedArray[0][0]=89;
            jaggedArray[0][1]=55;
            jaggedArray[0][2]=90;
            // 2nd rows
            jaggedArray[1][0]=55;
            jaggedArray[1][1]=65;
            jaggedArray[1][2]=67;
            jaggedArray[1][3]=88;
            jaggedArray[1][4]=100;
            //read
            Console.WriteLine($"Length - {jaggedArray.Length}" );
            Console.WriteLine($"Rank - {jaggedArray.Rank}" );

            for (int i = 0; i < jaggedArray.Length; i++) //rows
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) //rows
                {
                    Console.Write(jaggedArray[i][j]+" ");
                }
                Console.WriteLine();
            }

        }
        public static int[] Reverse(int[] x)
        {
            int[] reversed = new int[x.Length];
            for (int i = x.Length - 1; i >= 0; i--)
            {
                reversed[x.Length - 1 - i] = x[i];
            }
            return reversed;
        }
        
        public static void ReadArray(int[] anyArray){
             foreach (var a in anyArray)
            {
                Console.Write(a + " ");
            }
        }
        public static void MoveZeros(int[] y){
            ReadArray(y);
            
            Console.WriteLine();
            for (int i = 0; i < y.Length; i++)
            {
                if(y[i] == 0){
                    for (int j = i; j < y.Length-1; j++)
                    {
                        int temp = y[j];
                        y[j] = y[j+1];
                        y[j+1]=temp;
                    }
                }
            }
            ReadArray(y);
        }
    }
}