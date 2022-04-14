using System;
using System.Collections.Generic;

namespace ConsoleApp5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;

            List<string> files = new List<string>();
            files.Add("Иванов - Доктор");
            files.Add("Петров - Плотник");
            files.Add("Сидоров - Слесарь");

            while (isWorking)
            {
                Console.WriteLine("1 - Добавить досье\n2 - Показать все досье\n3 - Удалить досье\n4 - Выход"); 
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int value))
                {
                    switch (value)
                    {
                        case 1:
                            AddFile(files);
                            break;

                        case 2:
                            ShowAllFiles(files);
                            break;

                        case 3:
                            RemoveFile(files);
                            break;

                        case 4:
                            isWorking = false;
                            break;

                        default:
                            Console.WriteLine("Такой функции нет.\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Невозможно преобразовать {userInput} в число");
                }                
            }
        }

        static void AddFile(List<string> files)
        {
            Console.WriteLine("\nВведите фамилию и должность.");
            files.Add(Console.ReadLine());
            Console.WriteLine("\nФайл успешно добавлен.\n");            
        }

        static void ShowAllFiles(List<string> files)
        { 
            if (files.Count > 0)
            {
                Console.WriteLine("\nСписок файлов.\n");

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine();                
            }
            else
            {
                Console.WriteLine("Файлов нет.\n"); 
            }            
        }

        static void RemoveFile(List<string> files)
        {
            ShowAllFiles(files);
            Console.WriteLine("Какой по номеру файл удалить?");
            string userInput = Console.ReadLine();

            if(int.TryParse(userInput, out int value))
            {
                files.RemoveAt(value);
                Console.WriteLine("Файл полностью удален.\n");                
            }
            else
            {
                Console.WriteLine($"Невозможно преобразовать {userInput} в число");
            }           
        }
    }
}
