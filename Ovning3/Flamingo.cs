using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Flamingo class that inherits from Bird
    internal class Flamingo : Bird
    {
        private double height;
        // Unique property
        public double Height { get => height; set => height = value; }
        public Flamingo(string name, int age, double weight, double wingSpan, double height) : base(name, age, weight, wingSpan)
        {
            Height = height;
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Wing Span: {WingSpan}, Height: {Height}";
        }
    }
}
