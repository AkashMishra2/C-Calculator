namespace CSharp
{
    public class Calculator
    {
        public double AddMultipleNumbers(params double[] numbers)
        {
            double sum = 0;

            foreach (double n in numbers)
            {
                sum += n;
            }

            return sum;
        }

        public double MultiplyMultipleNumbers(params double[] numbers)
        {
            double mul = 1;

            foreach (double n in numbers)
            {
                mul *= n;
            }

            return mul;
        }

        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Division(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException(
                    "Cannot divide by zero.");
            }
            return x / y;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            Console.WriteLine(cal.AddMultipleNumbers(20, -62, 36, -96, 2, 41));
            Console.WriteLine(cal.MultiplyMultipleNumbers(20, -62, 36, -96, 2, 41));

            Console.WriteLine(cal.Addition(1, 2));
            Console.WriteLine(cal.Subtraction(13, 5));
            Console.WriteLine(cal.Multiplication(13, 5));
            Console.WriteLine(cal.Division(105, 2));
            Console.WriteLine(cal.Division(-105, 2));

        }

    }
}
