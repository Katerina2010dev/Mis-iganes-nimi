using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ForLoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni");
            Console.WriteLine("--------------------------------------");
            Console.Write("\n\n");

            int sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine("Summa on: " + sum);
            }
        }
    }
}



