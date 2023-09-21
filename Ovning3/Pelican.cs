using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Pelican class that inherits from Bird
    internal class Pelican : Bird
    {
        private string plumageColor;
        // Unique property
        public string PlumageColor { get => plumageColor; set => plumageColor = value; }
        public Pelican(string name, int age, double weight, double wingSpan, string plumageColor) : base(name, age, weight, wingSpan)
        {
            PlumageColor = plumageColor;
        }
        // Stats() method, returning all properties that the animal has.
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Wing Span: {WingSpan}, Plumage Color: {PlumageColor}";
        }
    }
}
