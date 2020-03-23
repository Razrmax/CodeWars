/*
 * Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

Example:
Kata.createPhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
The returned format must be correct in order to complete this challenge.
Don't forget the space after the closing parentheses!
 */
using System;

namespace CreatePhoneNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }

        static string CreatePhoneNumber(int[] numbers)
        {
            string phoneNumber = "";
            if (numbers.Length < 10)
            {
                return "Number not legal";
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        phoneNumber += '(';
                        break;
                    case 3:
                        phoneNumber += ") ";
                        break;
                    case 6:
                        phoneNumber += "-";
                        break;
                    default:
                        break;
                }

                phoneNumber += numbers[i];
            }

            return phoneNumber;
        }
    }
}
