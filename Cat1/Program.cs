using System;

namespace Cat1
{
    class cat
    {
        string name;
        string color;
        double hunger;

        public cat (string _name, string _color)
        {
            name = _name;
            color = _color;
            hunger = 0;

        }
        public string Name
        {
            get { return name; }
        }
        public string Color
        {
            get { return color; }
        }
        public double Hunger
        {
            get { return hunger; }
        }
        public void meow()
        {
            Console.WriteLine("Meow");
        }
        public void sleep()
        {
            Console.WriteLine("The cat is sleeping");
            hunger += 0.1;
            Console.WriteLine("Hunger:"+ hunger);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cat newCat = new cat("Isabella", "Orange and White");

            Console.WriteLine(newCat.Hunger);
            while (newCat.Hunger < 0.9)
            {
                newCat.sleep();
            }
        }
    }
}
