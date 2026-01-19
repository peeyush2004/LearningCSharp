using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void HandleMultipleExceptions(string input, int index)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                // May throw FormatException
                int parsedValue = int.Parse(input);

                // May throw IndexOutOfRangeException
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
