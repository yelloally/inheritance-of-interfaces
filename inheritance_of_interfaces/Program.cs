using System;
namespace inheritance_of_interfaces
{


    //implements IMammal interface
    class Dog : InterfacesOfAnimals.IMammal
    {
        private string breed;

        public Dog(string breed)
        {
            this.breed = breed;
        }

        //implementation of the method
        public void makeSound()
        {
            Console.WriteLine("The " + breed + " dog says woof!");
        }

        //implementation of the method
        public void giveBirth()
        {
            Console.WriteLine("The " + breed + " dog gives birth to puppies!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What breed is your dog?");
            string breed = Console.ReadLine();

            InterfacesOfAnimals.IMammal myAnimal = new Dog(breed);

            myAnimal.makeSound(); 
            myAnimal.giveBirth(); 

            Console.ReadKey();
        }
    }
}