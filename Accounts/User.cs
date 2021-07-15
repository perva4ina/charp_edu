using System;

namespace Accounts
{
    public class User
    {
        protected int Age { get; set; }
        protected string Name { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Display()
        {
            Console.WriteLine($"My name is {Name}. I'm {Age}");
        }
    }
}