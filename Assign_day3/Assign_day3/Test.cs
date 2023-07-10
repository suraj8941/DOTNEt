using System;


namespace Assign_day3
{
    public class Test
    {
        private int num1;
        private int num2;
        private int result;

        public Test(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
     
        }

        public void Divide()
        {
            try
            {
                result = num1 / num2;

                Console.WriteLine("Result: " + (result));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero not allowed");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter value for num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Test test = new Test(num1, num2);
            test.Divide();
            Console.ReadLine();
        }
    }
}
