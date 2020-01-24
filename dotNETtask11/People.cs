using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask11
{
    [Serializable]
    public class People
    {
        List<Person> persons;
        public People()
        {
            persons = new List<Person>();

        }
        public void LoadFromFile(string path)
        {
            Person tempPerson = null;
            using (StreamReader sr = File.OpenText(path) )
            {
                string input = sr.ReadLine();
                while ((input = sr.ReadLine()) != null)
                {
                    string[] dataLine = input.Trim().Split(';');
                    tempPerson = new Person
                    {
                        Name = dataLine[2],
                        Patronymic = dataLine[3],
                        LastName = dataLine[1],
                        Address = dataLine[6],
                        Phone = dataLine[7],
                    };
                    persons.Add(tempPerson);
                }
            }
        }

        public List<Person> Search(string str)
        {
            List<Person> result = new List<Person>();
            return result;
        }

        public void PrintAll()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }

    }
}
