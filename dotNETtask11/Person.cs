﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask11
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"ФИО: {Name} {Patronymic} {LastName}       [Телефон: {(Phone == String.Empty ? "нет" : Phone)}]       [Email: {Address}]";
        }
    }
}
