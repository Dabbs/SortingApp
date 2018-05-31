using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Sorting_Testing_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Go to the function showMenu and show the menu.
            showMenu();

        }

        // Precondition: None
        // Postcondition: Prints a menu screen and ask the user of where to go from the menu list.
        public static void showMenu()
        {
            StringBuilder menu = new StringBuilder();                      // Contains a variable for a string builder for menu.
            int menuChosen = 0;                                            // Contains an int variable for menu. 
            bool isNumberValidated = false;                                // Contains variable true or false if the user enters range menu correctly.

            // Create the string format for menu.
            menu.Append("#------------------MENU------------------#\n");
            menu.Append("              1. Merge Sort\n");
            menu.Append("              2. Bubble Sort \n");
            menu.Append("              3. Heap Sort\n");
            menu.Append("              4. Insertion Sort\n");
            menu.Append("              5. Fibonacci Recurrion\n");
            menu.Append("              10. Exit Application\n");
            menu.Append("#----------------------------------------#\n");

            // Print the menu screen.
            Console.WriteLine(menu);

            // Do while until the user enters the valid range from 1 to 10. Then select the menu input as that.
            do
            {
                // Get the chosen number from the user.
                menuChosen = Number.getNumberValidated("Please select the menu number between 1 and 10 from the menu list:");

                // If the user doesn't enter the range betweem 1 to 10. Then print error message on screen.
                if (menuChosen < 1 || menuChosen > 5)
                {
                    // Print error message on screen.
                    Console.WriteLine("\nError! The input you have choosen is not in the menu list.");
                }
                // else the user as choosen the a number from the menu list.
                else
                {
                    isNumberValidated = true;       // the number is valid from the menu.
                }

            }
            while (!isNumberValidated);             // Do while until the the user enters menu number correctly.

            // Go to the menu type
            goToWhatMenu(menuChosen);
        }

        // Precondition: Gets the value from the menu list.
        // Postcondition: Goes to the what type of sort it is.
        private static void goToWhatMenu(int whichMenu)
        {
            switch (whichMenu)
            {
                // Go to merge sort.
                case 1:
                    // mergeSort
                    mergeSort();

                    // Print screen
                    printContinueSceen();

                    break;
                // Go to bubble sort.
                case 2:
                    // bubble sort
                    bubbleSort();

                    // Print screen 
                    printContinueSceen();       

                    break;
                // Go to heap sort.
                case 3:
                    // heap sort
                    heapSort();

                    // Print Sceen 
                    printContinueSceen();
                    break;

                 // Go to insertion sort.
                case 4:
                    // heap sort
                    insertionSort();

                    // Print Sceen
                    printContinueSceen();
                    break;


                // Default to exit the application.
                default:
                    exitApplication();
                    break;
            }
        }

        // Precondition: None
        // Postcondition: Exit the application.
        private static void exitApplication()
        {
            Console.WriteLine("Goodbye! Please come again. :-)");
            Console.ReadKey();
            Environment.Exit(0);                            // Exit the application.
        }


        // Precondition: None
        // Postcondition: It will print a menu screen.
        private static void printContinueSceen()
        {
            // Print screen.
            Console.WriteLine("\nPlease enter any key to continue!");

            // Await user to press key.
            Console.ReadKey();
            Console.WriteLine("\n");

            // Show menu screen.
            showMenu();
        }

        // Precondition: None
        // Postcondition: It will get an array of numbers then sort it in merge sort. 
        private static void mergeSort()
        {
            int[] mergeSortNumbers = Number.userAskedNumberOfInputs("Please enter the range of merge sort:");
 
            // Print screen
            Console.WriteLine("------- Now showing MergeSort ------- ");

            // sort it out on the orginal array.
            Console.WriteLine("\nOriginal Array Elements :");
            printArray(mergeSortNumbers);

            // sort it out on the merge sort.
            MergeSort.mergeSort(mergeSortNumbers, 0, mergeSortNumbers.Length - 1);

            Console.WriteLine("\nSorted Array Elements :");
            printArray(mergeSortNumbers);
        }

        // Precondition: None
        // Postcondition: It will get an array of numbers then sort it in merge sort. 
        private static void bubbleSort()
        {
            int[] bubbleSortNumbers = Number.userAskedNumberOfInputs("Please enter the range of bubble sort:");
           
            // Print screen
            Console.WriteLine("------- Now showing Bubble Sort ------- ");

            // sort it out on the original array.
            Console.WriteLine("\nOriginal Array Elements :");
            printArray(bubbleSortNumbers);

            // sort it on the bubble sort.
            BubbleSort.bubbleSort(bubbleSortNumbers);

            Console.WriteLine("\nSorted Array Elements :");
            printArray(bubbleSortNumbers);

        }

        // Precondition: None
        // Postcondition: It will get an array of numbers then sort it in merge sort. 
        private static void heapSort()
        {
            int[] heapSortNumber = Number.userAskedNumberOfInputs("Please enter the range of heap sort:");

            // Print screen
            Console.WriteLine("------- Now showing Heap Sort ------- ");

            // sort it out on original array.
            Console.WriteLine("\nOriginal Array Elements :");
            printArray(heapSortNumber);

            // sort it out on heap sort.
            HeapSort.PerformHeapSort(heapSortNumber);

            Console.WriteLine("\nSorted Array Elements :");
            printArray(heapSortNumber);

        }

        // Precondition: None
        // Postcondition: It will get an array of numbers then sort it in merge sort. 
        private static void insertionSort()
        {
            int[] numbers = Number.userAskedNumberOfInputs("Please enter the range of insertion sort:");
            
            // Sort it out on original array.
            Console.WriteLine("\nOriginal Array Elements :");

            // Sort it out in insertion sort.
            InsertionSort.printIntegerArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");

            InsertionSort.printIntegerArray(InsertionSort.insertionSort(numbers));
            Console.WriteLine("\n");

        }

        // Precondition: Gets the array of number
        // Postcondition: Prints the array on screen.
        private static void printArray(int[] number)
        {
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
        }


    }


}