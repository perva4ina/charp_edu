using System;

namespace csharp_edu
{
    public class Animal
    {
        //public protected private

        public static int NumOfAnimals { get; private set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Sound { get; set; }
        private string name;

        public string Name
        {
            get => name;
            set => name = char.ToUpper(value[0]) + value.Substring(1);
        }

        public Animal()
        {
            Height = 0;
            Weight = 0;
            Sound = "No Sound";
            name = "No Name";
            NumOfAnimals++;
        }

        //call another constructor
        public Animal(string name, string sound) : this()
        {
            Name = name;
            Sound = sound;
            Console.WriteLine("Animal {0} created", this.name);
        }

        //OVERRIDE
        public override string ToString()
        {
            return "Animal name is " + name;
        }
    }

    public class Dog : Animal
    {
        public string FavoriteFood { get; set; }

        //call superclass constructor
        public Dog() : base()
        {
            FavoriteFood = "No favorite food";
        }
        
        //pass parameters to super constructor
        public Dog(string name, string sound, string favoriteFood) : base(name, sound)
        {
            FavoriteFood = favoriteFood;
        }

        public override string ToString()
        {
            return $"I am dog. My name is {Name} and my favorite food is {FavoriteFood}";
        }
    }
    
}