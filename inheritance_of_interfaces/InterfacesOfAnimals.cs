using System;
namespace inheritance_of_interfaces
{
	public interface InterfacesOfAnimals
	{
        //interface represents a method makeSound
        interface IAnimal
        {
            void makeSound();
        }

        //interface represents a method giveBirth
        interface IMammal : IAnimal
        {
            void giveBirth();
        }
    }
}

