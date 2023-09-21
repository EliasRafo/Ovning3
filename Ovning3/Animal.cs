using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Animal abstract class
    internal abstract class Animal
    {
        private string name;
        private int age;
        private double weight;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Weight { get => weight; set => weight = value; }

        // Creating an abstract method
        public abstract void DoSound();

        // Constructor
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        // Stats() method
        public abstract string Stats();
    }
}
