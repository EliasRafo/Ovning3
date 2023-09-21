using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class PersonHandler
    {
        // Set Age
        public void SetAge(Person person, int age) 
        {
            person.Age = age;
        }

        // Create Person
        public Person CreatePerson(int age, string fname,string lname, double height, double weight)
        {
            return new Person() { Age = age, FName = fname, LName = lname,Height = height, Weight = weight };
        }
        // Set full name
        public void SetFullName(Person person, string fname, string lname)
        {
            person.FName = fname;
            person.LName = lname;
        }
        // Set Height
        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }
        // Set Weight
        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }
    }
}
