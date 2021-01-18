using System;

// Interface
interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
}

interface IMagic
{
    void breatheFire(); // interface method
}

// Dragon "implements" the IAnimal interface
// May also implement multiple interfaces
class Dragon : IAnimal, IMagic
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The dragon says: roar");
    }

    public void breatheFire()
    {
        Console.WriteLine("The Dragon sets everything ablaze!");
    }

}
