using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Привет C#");
            string A = "полученные из переменных выводятся с помощью индексов аргументов из списка аргументов указанных после текстовой строки\n" +
            "и эти значения равны  под индексом {0}A - это наш текст:";
            double B = 456.1324;
            int C = 572;
            //{индекс,ширина: формат}
            Console.WriteLine("Значения {0} B {1, 4: #.##} С {2} {2} {2}", A, B, C);

        }
    }
}
