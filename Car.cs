using System;

// Object definitiion

class Car
{
  public string model;
  public string color;
  public int year;

  // Constructor
  public Car(string modelName, string modelColor, int modelYear)
  {
    model =  modelName;
    color = modelColor;
    year = modelYear;
  }


  // Property
   public string Model
   { 
     get; 
     set; 
    }

  // public keyword makes attribute accessible to other classes
  public void fullThrottle()
  {
    Console.WriteLine("Push it to the limit!");
  }
}