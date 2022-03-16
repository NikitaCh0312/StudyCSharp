using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Factorial is{result}");
        }
        // определение асинхронного метода
        static async void FactorialAsync()
        {
            Console.WriteLine("Begin method FactorialAsync"); // выполняется синхронно
            await Task.Run(() => Factorial());                // выполняется асинхронно
            Console.WriteLine("End method FactorialAsync");
        }


        static Task<int> FactorialAsyncWithResult()
        {
            Console.WriteLine("Begin method FactorialAsync"); // выполняется синхронно
            return Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("End method FactorialAsync");
                return 1000;
            });
            //Console.WriteLine("End method FactorialAsync");
        }

        static int FactorialAs()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            return result;
        }



        static void Main(string[] args)
        {
            FactorialAsync();   // вызов асинхронного метода

            var result = FactorialAsyncWithResult();
            Console.WriteLine(result.Result);

            Console.WriteLine("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Square is {n * n}");

            Console.Read();
        }
    }
}
