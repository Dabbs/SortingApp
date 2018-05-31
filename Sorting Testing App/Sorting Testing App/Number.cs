using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Testing_App
{
    class Number
    {
        public int number { get; set; }                                 // public access to number property.

        // Default constructor with paramter variable number.
        public Number(int number)
        {
            this.number = number; // sets the instance variable to assign with the number value.
        }

        // Default constructor
        public Number()
        {

        }

        // Precondition: None
        // Postcondition: Sets the index for each number.
        public static int[] userAskedNumberOfInputs(String message)
        {
            // Ask the user what is the range of how many numbers he/she wants to put in.
            int[] numbers = new int[getNumberValidated(message)];
            
            // Please enter the index from each number from the range that the user has choosen.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = getNumberValidated("Please enter the index " + i + " :");
            }

            return numbers;         // Returns the array for numbers.
        }

        // Precondition: Gets a string message.
        // Postcondition: 
        public static int getNumberValidated(string message)
        {
            bool isNumberInputCorrect = false;
            int number = 0;

            Console.WriteLine(message);      

            // Make sure the user input is correct.
            do
            {
                // Gets the input value from user.
                string input = Console.ReadLine();

                // Check if the user enters numberic input entry. 
                if (int.TryParse(input, out number))
                {
                    // If the user enters 0 or less then press error message on screen.
                    if (number < 1)
                    {
                        Console.WriteLine("Error! Please enter above 0!");
                    }
                    // Else is number input is valid.
                    else
                    {
                        isNumberInputCorrect = true;
                    }                  
                }

                // The input was invalid. Ask user to re-enter the input again.
                else
                {
                    Console.WriteLine("Error! The input is invalid. Please enter numeric as input only." );
                }
               
            }  while (!isNumberInputCorrect);  // Do while until the user enters the correct digits.

            // Returns the number input.
            return number;          
        }
        

    }
}
