using System;

namespace OperatorExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(5, 4));
            Console.WriteLine(Sub(5, 4));
            Console.WriteLine(Multiply(5, 4));
            Console.WriteLine(Division(5, 4));
            Console.WriteLine(Modulus(5, 4));
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine(a + " / " + b + "is " + quotient + " remainder " + remainder);

            Console.WriteLine("Please enter the radius of your circle");
           var userinput = Console.ReadLine();

            var radius = double.Parse(userinput);

            Console.WriteLine(AreaOfCircle(radius));


        }

        static int Add(int x,int y )
        {  return x + y; }
        

        static int Sub(int x, int y)
        { return x - y; }
        

        static int Multiply(int x, int y)
        { return x * y; }
       

        static int Division(int x, int y)
        { return x / y; }

        static int Modulus(int x, int y)
        {
            return x % y;
        }

        static double AreaOfCircle(double radius)
        {
        
         var area = Math.PI * Math.Pow(radius, 2);
        
         return area;




        }
        
    }
}
