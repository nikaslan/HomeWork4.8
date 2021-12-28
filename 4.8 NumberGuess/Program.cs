using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // без этого кириллица в консоли превращается в символы
            // объявление переменных

            int theNumber; // загаданное число
            int maxValue; // максимальное значение диапазона
            int guessValue; // введенное число

            string input; //пришлось ввести дополнительную переменную, чтобы различать введенные символы

            bool play = true; // играем пока играется

            Random rand = new Random(); // переменная для загадывания числа
            // основная логика
            while (play)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введи максимальное число для диапазона.");
                    while (!(int.TryParse(Console.ReadLine(), out maxValue)))
                    {
                        Console.WriteLine("Пожалуйста, введи целое число.");
                    }
                    if (maxValue < 10)
                    {
                        Console.WriteLine("Введи число побольше, так будет интереснее");
                        continue;
                    }
                    break;
                }

                theNumber = rand.Next(0,maxValue); // "загадываем" число

                Console.WriteLine($"Я загадал число от 0 до {maxValue}");
                Console.WriteLine("Введи свой ответ, и я скажу прав ли ты.\n");

                while (true)
                {
                    Console.Write("Ты думаешь, что это число: ");

                    while (!(int.TryParse(input = Console.ReadLine(), out guessValue)))
                    {
                        if (input == "")
                        {
                            Console.WriteLine("\nХочешь сдаться, так и не угадав? Чтобы сдаться - нажми Enter еще раз.\nЕсли хочешь продолжить - нажми любую другую клавишу");
                            if(Console.ReadKey(true).Key == ConsoleKey.Enter)
                            {
                                Console.WriteLine("\nОчень жаль");
                                guessValue = theNumber;
                                break;
                            }                               

                        }
                       Console.WriteLine("Ты ввел не число! Попробуй ввести число."); // почему кто-то будет вводить не число?
                    }
                    if (guessValue == theNumber) // условие завершения игры. Сюда попадаем если число было угадано или если игрок "сдался"
                    {
                        if (input != "") Console.WriteLine("\nДа! Ты угадал!"); // если мы пришли сюда не из диалога о выходе, то мы сообщаем, что человек угадал
                        Console.WriteLine($"Я загадывал число {theNumber}!");
                        
                        Console.WriteLine("\nХочешь выйти или сыграть еще? Нажми Enter, чтобы выйти. Нажми любую другую кнопку, чтобы продолжить.");
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter) //считываем нажатую кнопку и реагируем только на "Enter"
                        {
                            Console.WriteLine("\nДо встречи. Заходи поиграть еще.");
                            play = false;
                            Console.ReadLine();
                            break; 
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (guessValue < theNumber)
                    {
                        Console.WriteLine($"Попробуй ввести число побольше.");
                    }
                    else
                    {
                        Console.WriteLine($"Попробуй ввести число поменьше.");
                    }
                }
                
            }

        }
    }
}
