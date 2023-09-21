using System.Collections.Generic;

namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create object of Person class
                // Person person = new Person();

                // Create object of PersonHandler class
                PersonHandler handler = new PersonHandler();

                // Create persons
                var person1 = handler.CreatePerson(24, "James", "William", 180,86.4);
                var person2 = handler.CreatePerson(50, "Leo", "Nathan", 1.71, 64);
                var person3 = handler.CreatePerson(32, "Isabella", "Roland", 160, 54);

                handler.SetHeight(person1, 1.73);

                // Create a list of UserErrors
                var UserErrors = new List<UserError>();

                var userError1 = new NumericInputError();
                var userError2 = new TextInputError();
                var userError3 = new NumericInputError();

                UserErrors.Add(userError1);
                UserErrors.Add(userError2);
                UserErrors.Add(userError3);

                // Print UEMessage() through a foreach loop
                foreach (var error in UserErrors) 
                { 
                    Console.WriteLine(error.UEMessage());
                }

                Console.WriteLine();

                // Create three custom classes
                Custom1 x1 = new Custom1();
                Custom2 x2 = new Custom2();
                Custom3 x3 = new Custom3();

                UserErrors.Add(x1);
                UserErrors.Add(x2);
                UserErrors.Add(x3);

                foreach (var error in UserErrors)
                {
                    Console.WriteLine(error.UEMessage());
                }

                Console.WriteLine();

                /*
                 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det? 
                        We should put it in Bird class.

                14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
                        I will put the new attribute in Animal class.
                 */

                // Creating Animals list
                var Animals = new List<Animal>();

                // Creating some animals of different types
                var Animal1 = new Bird("Bird",4,1,10);
                var Animal2 = new Dog("Dog",10,10,5);
                var Animal3 = new Flamingo("Flamingo",6,6.4,15,2);
                var Animal4 = new Hedgehog("Hedgehog",1,1,100);
                var Animal5 = new Horse("Horse",14,60,200);
                var Animal6 = new Pelican("Pelican",6,8,10, "white");
                var Animal7 = new Swan("Swan",12,22,10,1);
                var Animal8 = new Wolf("Wolf",8,10, "brown");
                var Animal9 = new Worm("Worm",1,0.005,false);

                // Adding animals to Animals list
                Animals.Add(Animal1);
                Animals.Add(Animal2);
                Animals.Add(Animal3);
                Animals.Add(Animal4);
                Animals.Add(Animal5);
                Animals.Add(Animal6);
                Animals.Add(Animal7);
                Animals.Add(Animal8);
                Animals.Add(Animal9);
                
                foreach (var animal in Animals)
                {
                    Console.Write($"Animal name: {animal.Name}, animal sound: ");  // Printing animals that are in the list
                    animal.DoSound();  // Calling DoSound() method
                }

                Console.WriteLine();

                var Animal10 = new Wolfman("Wolf Man",24,68, "brown");
                Animals.Add(Animal10);

                for(int i = 0; i<Animals.Count;i++)
                {
                    if (Animals[i] is IPerson castedToIPerson)  // Checking if an animal is of type IPerson
                    {
                        castedToIPerson.Talk();  // Calling Talk() method
                    }
                }

                Console.WriteLine();

                // Creating Dogs list
                var Dogs = new List<Dog>();

                // Dogs.Add(Animal5);

                /*
                 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
                        Because it cannot convert from Horse to Dog

                10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
                        The list must be of type Animal

                13. F: Förklara vad det är som händer.
                        Stats() is abstract method in Animal abstract class. All classes that inherited 
                        from Animal class will override Stats() method, so when I call Stats() method it 
                        will return all properties of that animal.
                 */

                foreach (var animal in Animals)
                {
                    Console.WriteLine(animal.Stats()); // Printing animal Stats()
                }

                Console.WriteLine();

                foreach (var animal in Animals)
                {
                    if(animal is Dog)   // Printing the Stats() method of all dogs in Animals list
                    {
                        Console.WriteLine(animal.Stats());
                        // Console.WriteLine(animal.GetName());
                    }
                }

                /*
                 16. Kommer du åt den metoden från Animals listan?
                        No.
                17. F: Varför inte?
                        Because Animal class does not contain a definition for GetName() method.
                 */

                Console.WriteLine();

                foreach (var animal in Animals)
                {
                    if (animal is Dog castedToDog)
                    {
                        Console.WriteLine(castedToDog.GetName());
                    }
                }

            }
            catch(Exception e)  // handling the exceptions
            { 
                Console.WriteLine(e.Message.ToString());
            }
            
        }
    }
}