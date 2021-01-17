// Inheritance

using System;

class Animal // Base class (parent)
{
  public virtual void animalSound() // Add virtual keyword to state that method may be overwritten
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal // Derived class (child)
{
  public override void animalSound() // Override keyword will overwrite original method
  {
    Console.WriteLine("The pig says: oink oink");
  }
}

class Dog : Animal // Derived class (child)
{
  public override void animalSound()
  {
    Console.WriteLine("The dog says: woof woof");
  }
}