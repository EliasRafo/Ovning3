using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Bird class that inherits from Animal
    internal class Bird : Animal
    {
        private double wingSpan;

        public Bird(string name, int age, double weight, double wingSpan) : base(name, age, weight)
        {
            WingSpan = wingSpan;
        }
        // Unique property
        public double WingSpan { get => wingSpan; set => wingSpan = value; }
        // DoSound() method
        public override void DoSound()
        {
            Console.WriteLine("chirping");
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, WingSpan: {WingSpan}";
        }
    }
}
