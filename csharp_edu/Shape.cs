using System;

namespace csharp_edu
{
    public abstract class Shape
    {
        public string Name { get; init; }

        public abstract double Area();

        //virtual method - for overriding
        public virtual void PrintHello()
        {
            Console.WriteLine("Hello " + Name);
        }

        public override string ToString()
        {
            return $"Shape area is {Area()}";
        }

        protected Shape(string name)
        {
            Name = name;
        }
    }

    public class Square : Shape
    {
        public double Side { get; init; }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public Square(double side) : this("no name", side)
        {
        }

        public override double Area()
        {
            return Side * Side;
        }

        //sealed for block overriding this method in derived classes
        public sealed override void PrintHello()
        {
            base.PrintHello();
            Console.WriteLine("I am square");
        }

        //override operator
        public static Square operator +(Square s1, Square s2)
        {
            double newSide = s1.Side + s2.Side;
            return new Square(newSide);
        }
    }
}