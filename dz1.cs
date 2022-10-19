using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число");
            int first_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Введите число");
            int second_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int result = first_number + second_number;

            Console.WriteLine(result);
        }
    }
}
