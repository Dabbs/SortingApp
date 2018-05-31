// Reference: https://www.c-sharpcorner.com/UploadFile/3d39b4/bubble-sort-in-C-Sharp/

using System;

namespace Sorting_Testing_App
{
    class BubbleSort
    {
        // Prcondition: Gets the array of number
        // Postcondition: Sorts the bubble sort into an array.
        public static void bubbleSort(int[] number)
        {
            bool flag = true;                           // Set flag to be false until number J + 1 < number J sequence.
            int temp;                                   // Assigns the number J index as temporary.
            int numLength = number.Length;              // Assigns the number length of number array.

            //sorting an array
            // Repeat steps from for i to N while flag is equal to true.
            for (int i = 1; (i <= (numLength - 1)) && flag; i--)
            {
                flag = false;                           // Assigns flag to be false.

                // Repeat while J < N-1 
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] < number[j])
                    {
                        temp = number[j];           // Assign temp from number J index + 1.
                        number[j] = number[j + 1];  // Assigns number J index from number J + 1 index.
                        number[j + 1] = temp;       // Assigns number J index + 1 from temp;
                        flag = true;                // Assigns flag equal true.
                    }
                }
            }

        }
    }
}
