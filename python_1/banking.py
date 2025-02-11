using System;
using System.Collections.Generic;

namespace random
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Sanrio characters!");
            Console.WriteLine("Welcome, Sanrio Dressup!");

            bool helloKittyBlue = false;
            bool helloKittyRed = true;
            bool helloKittyGreen = false;
            int maxCharacter = 5;
            string characterSays = "hello, thank you for picking me & let's get this party started";

            int temperature = 30;

            if (helloKittyRed)
            {
                Console.WriteLine("Hello Kitty is red and no other color");
            }
            else
            {
                Console.WriteLine("Hello kitty is not green she is red");
            }

            if (temperature > 15)
            {
                Console.WriteLine("We are going to wear pink");
            }
            else
            {
                Console.WriteLine("We are going to wear blue");
            }

            int[] numbers = { 2, 4, 6, 8, 10, 12 };

            Console.WriteLine(numbers[1]);

            List<string> family = new List<string>();

            family.Add("London");
            family.Add("Tre");
            family.Add("Kimora");

            for (int i = 0; i < family.Count; i++)
            {
                Console.WriteLine(family[i]);
            }

            int charactersMade = 0;

            while (charactersMade < 7)
            {
                Console.WriteLine("charactersMade");
                charactersMade++;
            }

            for (int londons = 0; londons < 15; londons++)
            {
                Console.WriteLine("Clothes Loaded ");
            }
        }
    }
}
