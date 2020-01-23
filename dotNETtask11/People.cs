using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask11
{
    [Serializable]
    class People
    {
        List<Person> persons;
        People()
        {
            persons = new List<Person>();
        }
        void LoadFromFile(string path)
        {

        }

        List<Person> Search(string str)
        {
            List<Person> result = new List<Person>();
            return result;
        }


    }
}
