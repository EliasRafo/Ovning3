using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Wolfman class that inherits from Wolf and implements the IPerson interface
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight, string color) : base(name, age, weight, color)
        {
        }
        // Talk() method
        public void Talk()
        {
            Console.WriteLine("What Wolfman says");
        }

    }
}
