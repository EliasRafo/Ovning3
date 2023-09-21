using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Wolf class that inherits from Animal
    internal class Wolf : Animal
    {
        private string color;

        public Wolf(string name, int age, double weight, string color) : base(name, age, weight)
        {
            Color = color;
        }
        // Unique property
        public string Color { get => color; set => color = value; }
        // DoSound() method
        public override void DoSound()
        {
            Console.WriteLine("Howling");
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Color: {Color}";
        }
    }
}
