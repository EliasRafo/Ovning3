using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Horse class that inherits from Animal
    internal class Horse : Animal
    {
        private int speed;

        public Horse(string name, int age, double weight, int speed) : base(name, age, weight)
        {
            Speed = speed;
        }
        // Unique property
        public int Speed { get => speed; set => speed = value; }
        // DoSound() method
        public override void DoSound()
        {
            Console.WriteLine("Neighing");
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Speed: {Speed}";
        }
    }
}
