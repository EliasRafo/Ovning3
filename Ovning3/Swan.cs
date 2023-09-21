using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Swan class that inherits from Bird
    internal class Swan : Bird
    {
        private double neckLength;
        // Unique property
        public double NeckLength { get => neckLength; set => neckLength = value; }
        public Swan(string name, int age, double weight, double wingSpan, double neckLength) : base(name, age, weight, wingSpan)
        {
            NeckLength = neckLength;
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Wing Span: {WingSpan}, Neck Length: {NeckLength}";
        }
    }
}
