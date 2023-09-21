using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Dog class that inherits from Animal
    internal class Dog : Animal
    {
        private int hairLength;

        public Dog(string name, int age, double weight, int hairLength) : base(name, age, weight)
        {
            HairLength = hairLength;
        }
        // Unique property
        public int HairLength { get => hairLength; set => hairLength = value; }
        // DoSound() method
        public override void DoSound()
        {
            Console.WriteLine("Howling");
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Hair Length: {HairLength}";
        }
        // Creating a new method with an arbitrary name
        public string GetName()
        {
            return Name;
        }
    }
}
