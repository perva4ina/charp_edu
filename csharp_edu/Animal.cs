using System;

namespace csharp_edu
{
    public class Animal
    {
        //public protected private

        private double height { get; set; }
        private double weight { get; set; }
        private string sound { get; set; }
        private string name;
        private static int numOfAnimals;

        public static int NumOfAnimals => numOfAnimals;

        public string Name
        {
            get { return name; }
            set { name = char.ToUpper(value[0]) + value.Substring(1); }
        }

        public Animal()
        {
            height = 0;
            weight = 0;
            sound = "No Sound";
            name = "No Name";
        }

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Animal {0} created", this.name);
            numOfAnimals++;
        }

        //OVERRIDE
        public new string ToString()
        {
            return "Animal name is " + name;
        }

        
    }
}