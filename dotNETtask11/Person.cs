using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask11
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int Address { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\tPatronymic: {Patronymic}\tLast Name: {LastName}\tPhone: {Phone}\tAddress: {Address}";
        }
    }
}
