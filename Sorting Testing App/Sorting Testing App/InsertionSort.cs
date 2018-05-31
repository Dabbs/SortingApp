using System;
using System.Collections.Generic;
using System.Text;

// https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php

namespace Sorting_Testing_App
{

    class InsertionSort
    {
        // Preconditon: Gets the array of input array.
        // Postcondition: returns array of input array.
        public static int[] insertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        // Preconditon: Gets the array of array.
        // Postcondition: Prints on sceen the index of the array.
        public static void printIntegerArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write("\t {0}", number);

            }
        }


        // Preconditon: Gets the array of inputArray.
        // Postcondition: Returns array of inputArray.
        public static int[] insertionSortByShift(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int j;
                var insertionValue = inputArray[i];
                for (j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > insertionValue)
                    {
                        inputArray[j] = inputArray[j - 1];
                    }
                }
                inputArray[j] = insertionValue;
            }
            return inputArray;
        }
    }
}
