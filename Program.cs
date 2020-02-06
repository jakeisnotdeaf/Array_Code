using System;

namespace Array_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[25]; //create an array of 25 units of length 

            for (int i = 1; i <= 25; i++) //fills the array with 1-25
            {
                array[i-1] = i;
            }

            for (int i = 0; i < array.Length; i++) //loop to display 
            {


                Console.WriteLine("Element Value: " + array[i]); //displays value
            }
        }
    }
 }

