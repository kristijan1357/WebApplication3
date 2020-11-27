using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
    }
}