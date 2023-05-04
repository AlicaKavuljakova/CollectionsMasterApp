using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            int[] numbers = new int[50]; //TODO: Create an integer Array of size 50



            Populater(numbers);
            Console.WriteLine(numbers[0]); //TODO: Print the first number of the array

            Console.WriteLine(numbers[numbers.Length - 1]);//TODO: Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");



            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            Console.WriteLine("-------------------");


            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            List<int> nums = new List<int>();//TODO: Create an integer List


            //TODO: Print the capacity of the list to the console
            Console.WriteLine($" Current capacity is {nums.Capacity}");


            Console.WriteLine("---------------------");


            //TODO: Print the new capacity
            Populater(nums);
            Console.WriteLine($"Current capacity or the list is {nums.Capacity}");
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int input;
            bool isNum;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNum = int.TryParse(Console.ReadLine(), out input);
                Console.WriteLine("wrong type of input, try again");
            } while (!isNum);
            
            NumberChecker(nums, input);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(nums);
            
            
            Console.WriteLine("-------------------");


           
            Console.WriteLine("Evens Only!!");
            OddKiller(nums);
            Console.WriteLine($"This list contains {nums.Count} items, they're all odd numbers");
            
            Console.WriteLine("------------------");

            nums.Sort();
            NumberPrinter(nums);//TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            var myArray= nums.ToArray();
            //TODO: Clear the list
            nums.Clear();
        }

            #endregion  }
            static void Populater(int[] numbers)//TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Random rng = new Random();
                    numbers[i] = rng.Next(0, 50);
                }
            }

            static void ThreeKiller(int[] numbers) //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            {
                for (int i=0;i<numbers.Length;i++)
                {
                    if (numbers[i]%3==0)
                    {
                        numbers[i] = 0;
                    }
                } NumberPrinter(numbers);           
            }
            static void ReverseArray(int[] array)
            {                                      //TODO: Reverse the contents of the array and then print the array out to the console.

                //Try for 2 different ways
                //Array.Reverse(array); /*  1) First way, using a custom method => Hint: Array._____(); 

                for (int i = (array.Length - 1); i > 1; i--)
                {
                    Console.WriteLine(array[i]);

                }
                NumberPrinter(array);
                // 2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            }
            static void Populater(List<int> numberList)
            {
                for (int i=1; i<= 50;i++)
                {
                    Random rnd = new Random();
                    numberList.Add(rnd.Next(0, 50));
                }
                NumberPrinter(numberList);
            
        }
        
            static void OddKiller(List<int> numberList)     //TODO: Create a method that will remove all odd numbers from the list then print results
        {
            
            /*---My solution----------*/
            for (int i=0;i<numberList.Count;i++)
             {
                 if (numberList[i]%2 !=0)
                 {

                    numberList.Remove(numberList[i]);
                 }
             } 
             NumberPrinter(numberList);
            //var evenList= numberList.Where(x=> x%2!=0);
           
        }

             static void NumberChecker(List<int> numberList, int searchNumber)
            {
            var message = "";
            
                for (int i = 0; i < numberList.Count; i++)
                {
                    if (numberList[i]== searchNumber)
                    {
                        message = $"{searchNumber} is in the list";
                    }
                    else {
                        message = $"{searchNumber} is not in the list";

                    }
                }
        
            Console.WriteLine(message); 
            }

           





            /// <summary>
            /// Generic print method will iterate over any collection that implements IEnumerable<T>
            /// </summary>
            /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
            /// <param name="collection"></param>
            static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
            {
                //STAY OUT DO NOT MODIFY!!
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }

        
    }
}
