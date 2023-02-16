using System;
using System.Security.Cryptography.X509Certificates;

namespace AnimalInheritance
{

    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }
    // derived Class 
    class Elephant : Animal
    {
        private string favFood;
        protected double weight;
        public int age;

        public void setFavFood(string favFood) 
        {
            this.favFood = favFood;
        }
        public virtual string getFavFood() 
        {
            return favFood;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public virtual double getWeight()
        { 
            return weight; 
        }
        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return base.getType();     
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal creature = new Animal();
            creature.setName("Sparkles");
            creature.setType("Hamster");
            creature.color = "Brown";

            Console.WriteLine("Animal Information...");
            Console.WriteLine($"My name is {creature.getName()}");
            Console.WriteLine($"I am a {creature.getType()}");
            Console.WriteLine($"I am a {creature.color} color");
            Console.WriteLine();

            Elephant ele = new Elephant();
            ele.setName("Johnson");
            ele.setType("Asian Elephant");
            ele.color = "Gray";
            ele.setFavFood("peanuts");
            ele.setWeight(200);
            ele.age = 13;

            Console.WriteLine("Elephant Information...");
            Console.WriteLine($"My name is {ele.getName()}");
            Console.WriteLine($"I am a {ele.color} {ele.getType()}");
            Console.WriteLine($"I am {ele.age} years old and weigh {ele.getWeight()} pounds");
            Console.WriteLine($"My favorite food is {ele.getFavFood()}");

            Console.ReadLine();
        }
    }
}
