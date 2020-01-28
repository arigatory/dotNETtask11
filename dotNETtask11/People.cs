using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dotNETtask11
{
    [Serializable]
    public class People
    {
        List<Person> persons;
        string _fileName = "data.xml";
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
            foreach (Person p in persons)
            {
                if (p.Name.ToUpper().Contains(str) || p.Patronymic.ToUpper().Contains(str) ||
                    p.Phone.ToUpper().Contains(str) || p.Address.ToUpper().Contains(str) ||
                    p.LastName.ToUpper().Contains(str))
                {
                    result.Add(p);
                }
            }
            return result;
        }

        public void PrintAll()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }

        public void Save()
        {
            using (FileStream stream = new FileStream(_fileName,FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                serializer.Serialize(stream, persons);
            }
        }

        public void Load()
        {
            using (FileStream stream = new FileStream(_fileName, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                persons = (List<Person>)serializer.Deserialize(stream);
            }
        }

    }
}
