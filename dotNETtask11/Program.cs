using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask11
{
    class Program
    {
        static void Main(string[] args)
        {
            string userCommand = "";
            bool userDone = false;
            People people = new People();
            people.LoadFromFile("TemplateImportEmpl.csv");
            Console.WriteLine("***** Добро пожаловать! *****");
            try
            {
                ShowInstruction();
                do
                {
                    userCommand = Console.ReadLine().Trim();
                    Console.WriteLine();
                    switch (userCommand.ToUpper())
                        {
                            case "Д":
                                Console.WriteLine("Добавляем новое слово. Пожалуйста, введите новое слово:");
                                break;
                            case "У":
                                Console.WriteLine("Пожалуйста, введите слово, которое хотите удалить:");
                                break;
                            case "П":
                                Console.WriteLine("Введите слово, которое хотите найти:");
                                break;
                            case "В":
                                people.PrintAll();
                                break;
                            case "К":
                                ShowInstruction();
                                break;
                            case "З":
                                Console.WriteLine("Спасибо за пользование программой. До свидания!");
                                userDone = true;
                                break;
                            default:
                                Console.WriteLine("Вы ввели что-то не то, попробуйте снова! \"К\" - команды (список)");
                                break;
                        }
                } while (!userDone);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        //add translation
        private static void ShowInstruction()
        {            
            Console.WriteLine("Д: Добавить новую запись");
            Console.WriteLine("У: Удалить запись.");
            Console.WriteLine("П: Поиск.");
            Console.WriteLine("В: Вывести ВСЕХ сотрудников на экран");
            Console.WriteLine("К: Команды (список)");
            Console.WriteLine("З: Завершить");
        }
    }
}
