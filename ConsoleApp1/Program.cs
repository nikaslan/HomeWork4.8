using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // без этого кириллица в консоли превращается в символы
            // объявление переменных

            int sequenceSize; // количество элементов в последовательности
            int[] sequence; // количество столбцов матрицы
            int minValue = int.MaxValue; // минимальное значение элементов последовательности

            // основная логика
            Console.WriteLine("Пожалуйста введите количество элементов.");
            while(true)
            {
                while (!(int.TryParse(Console.ReadLine(), out sequenceSize)))
                {
                    Console.WriteLine("Пожалуйста, введите целое число.");
                }
                if (sequenceSize < 1)
                {
                    Console.WriteLine("Количество элементом должно быть больше нуля.");
                    continue;
                }
                break;
            }
            sequence = new int[sequenceSize]; // создаем одномерный массив для записи последовательности

            Console.WriteLine("Введите элементы последовательности, нажмите Enter для сохранения каждого элемента");
            for (int i = 0; i < sequenceSize; i++)
            {
                while (!(int.TryParse(Console.ReadLine(), out sequence[i])))
                {
                    Console.WriteLine("Пожалуйста, введите целое число.");
                }

                if (sequence[i] < minValue) minValue = sequence[i];
            }
            Console.WriteLine($"\n Минимальное число из введенной последовательности = \"{minValue}\"");

            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();

        }
    }
}
