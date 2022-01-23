using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Bird blueJay = new Bird();
            blueJay.CanSwim = true;
            blueJay.HasFeathers = true;
            blueJay.HasBeak = true;
            blueJay.NumberOfLegs = 2;
            blueJay.HasFur = false;
            blueJay.HasTail = true;
            blueJay.HasTalons = true;
            blueJay.CanFly = true;

            Console.WriteLine($"My new bird is a blue jay it is {blueJay.CanSwim} that he can swim and fly");
            Console.WriteLine($"it is {blueJay.HasFeathers} that he has feathers and has a break");
            Console.WriteLine($"he has {blueJay.NumberOfLegs} legs and {blueJay.NumberOfLegs} wings ");

            Reptile turtles = new Reptile();
            {
                turtles.CanSwim = true;
                turtles.IsColdBlooded = true;
                turtles.HasFur = false;
                turtles.HasTail = true;
                turtles.EatsBugs = true;
                turtles.HasScales = true;
                turtles.LaysEggs = true;
                turtles.NumberOfLegs = 3;
            }
            Console.WriteLine($"my new turtle is really cool he has {turtles.NumberOfLegs} legs and it is {turtles.HasScales} that he can swim really fast!");

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
