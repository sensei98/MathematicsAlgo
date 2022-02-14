using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new();
            program.start();
        }
        void start()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            //fabonacci(n);
            int result = fabonacciRecursive(n);
            Console.WriteLine($"result: {result}");
        }

        //Assignment2A
        void fabonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;

            for(int i = 1; i < n; i++)
            { 
                Console.Write($"{f0}, ");
                int sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
        }


        //Assignment2B
        int fabonacciRecursive(int n)
        {
            int f;
            if (n >= 2)
            {
                f = fabonacciRecursive(n - 1) + fabonacciRecursive(n - 2);
            }
            else
            {
                return n;
            }
            return f;


            //if(n == 0)
            //{
            //    return 0;
            //}
            //else if (n == 1)
            //{
            //    return 1;
            //}
            //else
            //{
               
            //    Console.WriteLine($"f({n}) = f({n - 1}) x {n} = {f}");
            //}
            //return f;
           
            
        }
    }
}
