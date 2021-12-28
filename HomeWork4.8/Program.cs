using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // без этого кириллица в консоли превращается в символы
            // объявление переменных
            Random rand = new Random(); //переменная типа Random для заполнения массива

            int rowNum; // количество строк матрицы
            int colNum; // количество столбцов матрицы
            int matrixSum = 0; // сумма всех элементов матрицы

            // основная логика
            Console.WriteLine("Введите количество строк");
            while(!(int.TryParse(Console.ReadLine(), out rowNum))) // считываем количество строк
            {
                Console.WriteLine("Введите целое число");
            }

            Console.WriteLine("Введите количество столбцов");
            while (!(int.TryParse(Console.ReadLine(), out colNum))) // считываем количество столбцов
            {
                Console.WriteLine("Введите целое число");
            }

            
            int[,] randMatrix = new int[rowNum,colNum]; //объявляю матрицу размером rowNum на colNum

            for (int i = 0; i < randMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randMatrix.GetLength(1); j++)
                {
                    randMatrix[i, j] = rand.Next(100); //заполняю матрицу случайными целыми числами. Ограничиваю до 100, чтобы было удобнее
                    Console.Write($"{randMatrix[i, j],3} ");
                    matrixSum += randMatrix[i, j];
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine($"Сумма всех элементов матрицы = {matrixSum}");
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}
