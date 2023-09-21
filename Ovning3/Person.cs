using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    // Person class
    internal class Person
    {
        // private fields
        private string fName;
        private string lName;
        private int age;
        private double height;
        private double weight;

        // public properties
        public string FName { get => fName;
            set
            {
                // Implementing validation
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("FName is mandatory");
                if(value.Length<2 || value.Length > 10)
                    throw new ArgumentException("FName cannot be less than 2 characters or longer than 10 characters");
                fName = value;
            }
        }
        public string LName { get => lName;
            set
            {
                // Implementing validation
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("LName is mandatory");
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("LName cannot be less than 3 characters or longer than 15 characters");
                lName = value;
            }
        }
        public int Age
        {
            get => age; 
            set
            {
                // Implementing validation
                if (value <= 0)
                    throw new ArgumentException("Age can only be assigned a value greater than 0.");
                age = value;
            }
        }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
    }
}
