using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.Lesson_2
{
    class Level_2_Task_6
    {
        static void Main(string[] args)
        {
            /*
             * 1.Сгенерировать 3 случайных числа и вывести их на экран.
             * 2.Посчитать сумму этих чисел и вывести результат на экран.
            */

            /* для генерации случайных чисел есть несколько способов, но мы рассмотрим один пока.
             * Есть класс Random. Например нам нужно сгенерировать одно случайное число. 
             * Мы должны сначала обратиться к классу Рэндом. 
             * это делается так:
             ** 
             * Random randomGenerator = new Random(); 
             * что тут происходит: 
             * первое слово Random это тип переменной, т. е. тип класса Рэндом. 
             * второе название переменной, 
             * равно это присвоение,, как и раньше мы делали с переменными.
             * ну и new Random() мы говорим что создай нам новый экземпляр класса Рэндом. 
             * Обычное объявление переменной. Только с использованием класса.
             * Например у тебя будет класс с названием Студент. Чтобы обратиться к нему ты 
             * создашь переменную неважно какое имя, например студент1 тип Студент и присвоишь ему 
             * нью Студент(). Человеческим языком это звучит так:
             * Создай мне студент1 типа Студент. тут студент1 выступает как Объект, который будет иметь
             * свойства и поведение твоего класса Студент.
             * давай попробуем на примере рэндома
             * 
             */
            Random randomGenerator = new Random(); // Теперь у моей переменной randomGenerator есть все свойства и поведения класса Рэндом. это позже будет понятнеее когда мы будем применять ООП в коде.

            /*
             * Теперь мы можем создать переменную типа инт с рэндомным значением.
             * создай просто переменную инт 
             * теперь нам нужно само число случайное присоить этой переменной. 
             * У нас есть переменная рэндомГенератор. присвой её нашему числу. и нажми точку после слова randomGenerator
             */

            int firstRandomNumber = randomGenerator.Next(1, 100);
            int secondRandomNumber = randomGenerator.Next(100, 200);
            int thirdRandomNumber = randomGenerator.Next(300);

            Console.WriteLine($"The first = {firstRandomNumber}, The second = {secondRandomNumber}, The third = {thirdRandomNumber}");
            Console.WriteLine($"Amount = {firstRandomNumber + secondRandomNumber + thirdRandomNumber}");
            Console.ReadKey();
        }
    }
}
