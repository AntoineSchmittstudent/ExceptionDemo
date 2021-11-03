using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[2];
/*           try
           {
                numbers[0] = 0;
                numbers[1] = 1;
                //numbers[2] = 2;
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }

           }*/
            try
            {
                Divide(6, 0, "Answer");
            }
            catch(IndexOutOfRangeException ex)
           {
                Console.WriteLine("An IndexOutOfRangeException was thrown");
           }
           catch(Exception e)
           {
                Console.WriteLine("A General Exeption was thrown ");
           }
           finally
           {
                Console.WriteLine("Finished process, exeption thrown, have closed all issues");
           }
            try
            {
                Show(null, 59);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
        private static void Divide(int a, int b, string ans)
        {
            int result = a / b;
            Console.WriteLine($"{ans.ToUpper()} : {result}");
        }
        private static void Show(string fname,int age)
        {
            if( fname is null)
            {
                throw new ArgumentException("Name cannot be null", "fname");
            }
        }
    }
}
