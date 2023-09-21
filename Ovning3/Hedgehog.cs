using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Hedgehog class that inherits from Animal
    internal class Hedgehog : Animal
    {
        private int spikes;

        public Hedgehog(string name, int age, double weight, int spikes) : base(name, age, weight)
        {
            NrOfSpikes = spikes;
        }
        // Unique property
        public int NrOfSpikes { get => spikes; set => spikes = value; }

        // DoSound() method
        public override void DoSound()
        {
            Console.WriteLine("Snuffling");
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, NrOfSpikes: {NrOfSpikes}";
        }
    }
}
