namespace CSharpBasics
{
    public class ExceptionHandling
    {
        public static float Divide(int numerator, int denominator){
            float result=0;
            try{
                result = numerator/denominator;
            }
            catch(DivideByZeroException ex){
                //Logging Logic => NLog
                Console.WriteLine(ex.Message);
            }
            catch(ArithmeticException ex){
                //Logging Logic
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex){
                //logging Logic
                Console.WriteLine(ex.Message);
            }
            finally{
                Console.WriteLine("Finally runs irrespective of exceptions");
                // logic for clean of resources
                // closing opened resources to anyone to use
            }
            return result;
        }
    }

    public class Temperature
    {
        public static void CheckTemperature(float temp){
            if(temp<30){
                throw new TemperatureException("Too cold temperature for this device, please take it to a warm place between 65 F to 80 F");
            }
            else
                Console.WriteLine("Congrats! your device is healthy");
        }

    }

    public class TemperatureException : ApplicationException
    {
        public TemperatureException(string message):base(message){

        }
    }
}