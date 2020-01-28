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
            try
            {
                people.Load();
                Console.WriteLine("Данные загружены из xml файла");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Программа запущена первый раз, загружаются тестовые данные из файла csv");
                people.LoadFromFile("TemplateImportEmpl.csv");
                Console.WriteLine("Данные загружены успешно!");
                people.Save();
            }
            
            Console.WriteLine("***** Добро пожаловать! *****");
            try
            {
                ShowInstruction();
                do
                {
                    Console.Write("\n>");
                    userCommand = Console.ReadLine().Trim();
                    Console.WriteLine();
                    switch (userCommand.ToUpper())
                        {
                            case "Д":
                                AddNewEmployee();
                                break;
                            case "У":
                                DeleteEmployee();
                                break;
                            case "П":
                                SearchEmployee(people);
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

        private static void SearchEmployee()
        {
            throw new NotImplementedException();
        }

        private static void SearchEmployee(People p)
        {
            Console.WriteLine("Введите данные для поиска (фамилию, имя, телефон и тп)");
            string input = Console.ReadLine().Trim();
            List<Person> searchResult = p.Search(input.ToUpper());
            foreach (Person person in searchResult)
            {
                Console.WriteLine(person);
            }
            if (searchResult.Count() == 0)
            {
                Console.WriteLine("Ничего не найдено");
            }
            
        }

        private static void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        private static void AddNewEmployee()
        {
            throw new NotImplementedException();
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
