using System;
using System.Linq; // Contains helpful methods such as Min, Max, Sum

/* Table of Contents:

Methods   :190
Classes and Objects :241

*/

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Wassup, the time is {DateTime.Now}");

            // Casting

            // Implicit - Smaller to Larger
            int number = 9;
            double dub = number;

            Console.WriteLine(number);
            Console.WriteLine(dub);

            // Explicit - Larger to Smaller
            double newDub = 9.78;
            int newNumber = (int) newDub;

            Console.WriteLine(newNumber);
            Console.WriteLine(newDub);

            // Get User Input
            // Console.WriteLine("Enter User Name:");

            // string userName = Console.ReadLine();

            // Console.WriteLine("Enter Age: ");

            // int userAge =  Convert.ToInt32(Console.ReadLine());

            // var value = $"You entered: {userName}. \nAge: {userAge} ";
            // Console.WriteLine(value);

            // Conditionals

            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            // if... else if... else

            int time = 22;

            if (time < 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");

            }

            // Terinary

            string result = (time < 18) ? "Good Day" : "Good Evening";
            Console.WriteLine(result);

            // Switch

            int day = 8;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            // While loops

            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // do/while loop

            i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            // For loops

            // int i already defined in line 104
            for (i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // foreach loop

            string[] cars = { "Volvo", "BMW","Ford", "Mazda" };  // Defines and array of strings (string[]) Note: Curly brackets surround the elements

            foreach (string c in cars)
            {
                if (c == "BMW")
                {
                    Console.WriteLine("Too Expensive");
                    continue;  // Skips to next iteration
                }
                Console.WriteLine(c);
            }

            // Access an element in the array
            Console.WriteLine(cars[1]); // Outputs BMW

            // Change an element in the array
            cars[0] = "Toyota";
            Console.WriteLine(cars[0]);  // Outputs Toyota instead of Volvo

            // Sort an  array of strings

            Array.Sort(cars); //Sorts an array by alphabetical order in ascending order
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Sort an array of int
            int[] myNumbers = {5, 1, 8, 9};

            Array.Sort(myNumbers);// Sorts an array of ints in ascending order
            foreach (int num in myNumbers)
            {
                Console.WriteLine(num);
            }

            // Min, Max and Sum can be found in the System.Linq namespace
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());



            // // Create an array of four elements, and add values later
            // string[] cars = new string[4];

            // // Create an array of four elements and add values right away 
            // string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // // Create an array of four elements without specifying the size 
            // string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            // // Create an array of four elements, omitting the new keyword, and without specifying the size
            // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};


            
            // Execute Methods
            MyMethod();
            AnotherMethod("Jameel");

            // Default method with argument
            CountryMethod("Switzerland");
            // Default method without argument
            CountryMethod();

            // Multiple Arguments
            MultipleParams("Jameel", 26);

            // Return values
            Console.WriteLine(AddFive(10));

            // Or store the result in a variable
            int newVar = AddFive(20);
            Console.WriteLine(newVar);

            // Named Arguments - key: value syntax (Order does not matter)
            SomeNames(child3: "Joseph",child1: "Joshua"  , child2: "Jonah");

            //Named Default
            Huh("child3");

            // Calling overloaded method
            int myNum1 = PlusMethod(10, 20);
            double myNum2 = PlusMethod(5.2, 4.5);

            Console.WriteLine($"{myNum1} {myNum2}");

            // Accessing methods
            Car Ford = new Car("Mustang", "Red", 1969);


            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.model);

            Ford.fullThrottle();

            Ford.Model = "Focus";
            Console.WriteLine(Ford.Model);

            // Calling inherited classes (See: Animal.cs)

            Animal myAnimal = new Animal();  // create animal object
            Animal myPig = new Pig(); //create pig object
            Animal myDog = new Dog(); // create dog object(

            Pig newPig = new Pig(); // Note: Creating from the derived class will yield correct result should override keyword not be used


            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            newPig.animalSound();


            // Calling Abstract classes
            AbPig thatPig = new AbPig();


            // Calling interface
            Dragon myDragon = new Dragon(); // Create a dragon object
            myDragon.animalSound();
            myDragon.breatheFire();
            
            //Calling enum value

            Months month = Months.January;
            int monthOfTheYear = (int) Months.January;
            
            Console.WriteLine(month);
            Console.WriteLine(monthOfTheYear);



        }

           
        // Define Method
        static void MyMethod()
        {
            Console.WriteLine("Jack In! Execute!");
        }

        // Defining a Method with parameters
        static void AnotherMethod(string fname)
        {
            Console.WriteLine($"See: {fname}");
        }

        // Default parameters
        static void CountryMethod(string country = "Netherlands")
        {
            Console.WriteLine($"Some day I'm moving to {country}");
        }

        // Multiple parameters
        static void MultipleParams(string aName, int aNumber)
        {
            Console.WriteLine($"{aName}, {aNumber}");
        }

        // Return values
        static int AddFive(int aNum)
        {
            return aNum + 5;
        }

        // Named Arguments example
        static void SomeNames(string child1, string child2, string child3)
        {
            Console.WriteLine($"The youngest child is: { child3 }");
        }

        // Named Defaults
        static void Huh(string child1 = "Liam", string child2 = "Jackson", string child3 = "Joaquin")
        {
            Console.WriteLine(child2);
        }

        // Method Overloading
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

         // Enum Examples

        enum Months
        {
            January = 1, // enum defaults to 0,1,2,3... unless specified
            Fenruary, // by default enum will increment from the previous value
            March
        }


    }
}