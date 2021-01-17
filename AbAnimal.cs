using System;

// Abstract classes and methods
abstract class AbAnimal
{
  public abstract void animalSound();
  public void sleep()
  {
      Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from AbAnimal)
class AbPig : AbAnimal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: oink oink");
    }
}