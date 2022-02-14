using System;

namespace assignment1
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
            Console.Write($"n = ");
            int n = int.Parse(Console.ReadLine());
            factorial(n);
            Console.WriteLine("\n---------------------------------------");
            recursiveFactorial(n);
        }

        //Assignment1A
        int factorial(int n)
        {
            int total = 1;
            Console.Write($"{n}! = ");
            for (int i = 1; i <= n; i++)
            {
                total = i * total;
                if (i < n)
                {
                    Console.Write($"{i} x ");
                }
                else
                {
                    Console.Write($"{i} = {total}");
                }
            }
            return total;
        }

        //Assignment1B
        int recursiveFactorial(int n)
        {
            //(n!) = n * (n-1)! //recursive
            int f;
            if (n > 1)
            {
               f = recursiveFactorial(n - 1) * n;
                Console.WriteLine($"f({n}) = f({n-1}) x {n} = {f}");
            }
            else
            {
                Console.WriteLine($"f({n}) = {n}");
                return 1;
            }
            return f;
        }
    }
}
