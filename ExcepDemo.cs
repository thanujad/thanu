using System;

namespace Class_Demos
{
    class ExcepDemo
    {
        static void Main(string[] args)
        {
            int div=0, number=0;
            try
            {
                div = 100 / number;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception occured : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Result is: {0}", div);
                Console.WriteLine("\nPress ENTER to Quit...");
                Console.ReadKey();
            }
        }
    }
}
