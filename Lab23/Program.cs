using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);
            Console.ReadKey();
        }

        static void Sum(int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }
        static void Fact(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }

        static async void SummAsync(int n)
        {
            await Task.Run(() => Sum(n));
        }

        static async void FactAsync(int n)
        {
            await Task.Run(() => Fact(n));
        }
    }
   
}


