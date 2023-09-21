using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Worm class that inherits from Animal
    internal class Worm : Animal
    {
        private bool isPoisonous;

        public Worm(string name, int age, double weight, bool isPoisonous) : base(name, age, weight)
        {
            IsPoisonous = isPoisonous;
        }
        // Unique property
        public bool IsPoisonous { get => isPoisonous; set => isPoisonous = value; }
        // DoSound() method
        public override void DoSound()
        {
            Console.WriteLine("chirping");
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, IsPoisonous: {IsPoisonous}";
        }
    }
}
