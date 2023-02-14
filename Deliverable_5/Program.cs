/*
Program Author: Chris Parrado
Date: 2/13/23
Program Description: C# Console Program that uses methods to populate/sum arrays based on user input.

*/

using System;
namespace Deliverable_5
{
    class Program
    {
        static int[] random_array(int array_len)   // Method to create array and insert random numbers into array
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10,50);
            }
            return MyArray;
        }

        static int sum(int[] array)   // Method to sum the elements in array
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {

                while (true)    // While loop to redo process if user doesn't enter integer between 5 and 15
                {
                    Console.WriteLine("Enter an Integer between 5 and 15");
                    int input = int.Parse(Console.ReadLine());
                    if (input >= 5 && input <= 15)             // conditional statement to make sure input is between 5 and 15
                    {
                        int[] sampleArray = random_array(input);

                        Console.WriteLine("The elements of the random array are: ");
                        foreach (int element in sampleArray)
                        {
                            Console.Write(element + " ");
                        }

                        Console.WriteLine("");
                        Console.WriteLine("The sum is: " + sum(sampleArray));
                        break;
                    }
                }
            } 
            catch
            {
                Console.WriteLine("Invalid Entry. Please enter an integer that is between 5 and 15");
            }
        }
    }
}
