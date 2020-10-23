using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.Lesson_2
{
    class Level_1_Task_5
    {
        static void Main(string[] args)
        {
            /*Продемонстрировать работу с операциями сложения, вычитания, умножения и деления, и вывести результат вычислений на экран. */

            // Дано 558 и 125, найти сумму (amount).

             int a = 558;
             int b = 125;
             int result = a + b;
             Console.WriteLine(result);
             Console.ReadKey();

            // Дано 90 и 10, найти разность (difference).    

            int x = 90;
            int y = 10;
            result = x - y;
            Console.WriteLine(result);
            Console.ReadKey();

            // Дано 200 и 5, найти частное (quotient).

            int m = 200;
            int n = 5;
            result = m / n;
            Console.WriteLine(result);
            Console.ReadKey();

            // Дано 59 и 11, найти произведение (productOfNumber).

            int k = 59;
            int l = 11;
            result = k * l;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
