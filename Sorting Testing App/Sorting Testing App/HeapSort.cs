using System;
using System.Collections.Generic;
using System.Text;

// https://simpledevcode.wordpress.com/2014/11/25/heapsort-c-tutorial/
namespace Sorting_Testing_App
{
    class HeapSort
    {
        // Preconditon: Gets the array of arr, and heap size
        // Postcondition: Sorts heap sort.
        private static void BuildHeap(int[] arr, int heapSize)
        {
            heapSize = arr.Length - 1;                                      
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i, heapSize);
            }
        }

        // Preconditon: Gets the array of arr, x and y value.
        // Postcondition: Swaps the array indexes.
        private static void Swap(int[] arr, int x, int y)//function to swap elements
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        // Preconditon: Gets the array of arr, index and heapsize.
        // Postcondition: Sorts heap sort.
        private static void Heapify(int[] arr, int index, int heapSize)
        {
            int left = 2 * index;             // <i Left(i)  
            int right = 2 * index + 1;         // r <i right(i)
            int largest = index;               // largest = i

            // if left <= heapSize[a] and A[i} > A[i]
            if (left <= heapSize && arr[left] > arr[index])
            {
                // then largest <- i
                largest = left;         
            }

            // r=< heap-size[A] and A[r} > A[largest]
            if (right <= heapSize && arr[right] > arr[largest])
            {
                // largest <-r
                largest = right;       
            }

            // if largest != i
            if (largest != index)
            {
                // then SWAP A[largest]
                Swap(arr, index, largest);
                Heapify(arr, largest, heapSize);
            }
        }

        // Preconditon: Gets the array of arr, and heap size
        // Postcondition: Sorts heap sort.
        public static void PerformHeapSort(int[] arr)
        {
            int heapSize = arr.Length - 1;
            BuildHeap(arr, heapSize);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0, heapSize);
            }
        }
    }
}
