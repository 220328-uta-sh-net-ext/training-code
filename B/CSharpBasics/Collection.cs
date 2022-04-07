namespace CSharpBasics
{
    public class Collection
    {
        public static void Arrays_1D(){
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

        public static void Arrays_MultiDimensional(){
            int[,] twoDArray = new int[2,3]; // 2D array with 2 rows and 3 columns
            Console.WriteLine($"Size = {twoDArray.Length}");
            Console.WriteLine($"Rank = {twoDArray.Rank}");

            twoDArray[0,0] = 1;
            twoDArray[1,0] = 2;

            //read an element
            //Console.WriteLine(twoDArray[1,2]);

            for (int i = 0; i < 2; i++)  // rows
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(twoDArray[i,j]+ " ");
                }
                Console.WriteLine();
            }


        }
    }
}