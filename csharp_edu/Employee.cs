using System;
using Accounts;

namespace csharp_edu
{
    public class Employee : User
    {
        public string Company { get; set; }

        public Employee(string name, int age, string company) : base(name, age)
        {
            Company = company;
        }

        public override void Display()
        {
            Console.WriteLine($"My name is {Name}. I'm {Age}. I work for {Company}");
        }
    }
}