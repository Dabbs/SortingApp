// Reference: https://gist.github.com/pmgeorg/9122984

namespace Sorting_Testing_App
{
    class MergeSort
    {

        // Preconditon: Gets the the array of input, start index and end index.
        // Postcondition:  //merge sort recurcive
        public static void mergeSort(int[] input, int startIndex, int endIndex)
        {
            int middle = 0;                         // Assign middle as 0 value.

            // If endindex if greater than starindex then process with statement.
            if (endIndex > startIndex)
            {
                middle = (endIndex + startIndex) / 2;                           
                mergeSort(input, startIndex, middle);                          
                mergeSort(input, (middle + 1), endIndex);
                merge(input, startIndex, (middle + 1), endIndex);
            }
        }

        // Preconditon: Gets the array of arr, and heap size
        // Postcondition: Sorts merge sort.
        public static void merge(int[] input, int left, int middle, int right)
        {
            //Merge procedure takes theta(n) time
            int[] temp = new int[input.Length];                                 // Assign the temp from input length.
            int leftEnd = 0;                                                    // Assign left end as 0.
            int lengthOfInput = 0;                                              // Assign legnofinput as 0.
            int tempPosition = 0;                                               // Assign temppostion as 0.

            leftEnd = middle - 1;                                               // Assign lefENd as middle - 1.
            tempPosition = left;                                                // Assign temPostion from left.
            lengthOfInput = right - left + 1;                                   // Assign lngthOfInput from right - left + 1.

            //selecting smaller element from left sorted array or right sorted array and placing them in temp array.
            while ((left <= leftEnd) && (middle <= right))
            {
                // If input left index is <= input middle index then assign temp Position + 1 index from input left + 1 index.
                if (input[left] <= input[middle])
                {
                    temp[tempPosition++] = input[left++];
                }
                // If input left index is <= input middle index then assign temp Position + 1 index from input middle + 1 index.
                else
                {
                    temp[tempPosition++] = input[middle++];
                }
            }
            //placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[tempPosition++] = input[left++];
            }

            //placing remaining element in temp from right sorted array
            while (middle <= right)
            {
                temp[tempPosition++] = input[middle++];
            }

            //placing temp array to input
            for (int i = 0; i < lengthOfInput; i++)
            {
                input[right] = temp[right];
                right--;
            }
        }

    }
}
