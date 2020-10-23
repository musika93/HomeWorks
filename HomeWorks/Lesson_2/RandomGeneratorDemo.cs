using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.Lesson_2
{
    class RandomGeneratorDemo
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();

            int firstRandomNumber = randomGenerator.Next();
            int secondRandomNumber = randomGenerator.Next();
            int thirdRandomGenerator = randomGenerator.Next();
            Console.WriteLine($"The first = {firstRandomNumber}, The second = {secondRandomNumber}, The third = {thirdRandomGenerator}");
            Console.WriteLine($"Amount = {firstRandomNumber + secondRandomNumber + thirdRandomGenerator}");
            Console.ReadKey();
        }
    }
}
