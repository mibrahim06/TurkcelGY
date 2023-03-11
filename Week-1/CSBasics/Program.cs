// See https://aka.ms/new-console-template for more information

namespace CSBasics
{
    /**
    * This program is a basic example of Loop and Array operations
    */
    internal static class Program
    {
        // Array operations with For Loop
        private static void ArrayOperationsForLoop(int[] array)
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Array operations with For Loop:");
            // Sum of all numbers
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum of all numbers: {sum}");
            // Biggest number
            int biggestNumber = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestNumber)
                {
                    biggestNumber = array[i];
                }
            }
            Console.WriteLine($"Biggest number: {biggestNumber}");
            // Smallest number
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallestNumber)
                {
                    smallestNumber = array[i];
                }
            }
            Console.WriteLine($"Smallest number: {smallestNumber}");
            // Sum of min and max number in the array
            int sumMinMax = biggestNumber + smallestNumber;
            Console.WriteLine($"Sum of min and max number in the array: {sumMinMax}");
            // Average of all numbers
            int average = sum / array.Length;
            Console.WriteLine($"Average of all numbers: {average}");
            // Count of even numbers
            int countEvenNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    countEvenNumbers++;
                }
            }
            Console.WriteLine($"Count of even numbers: {countEvenNumbers}");
            // Count of odd numbers
            int countOddNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    countOddNumbers++;
                }
            }
            Console.WriteLine($"Count of odd numbers: {countOddNumbers}");
            Console.WriteLine("For operations finished");
        }
        // Array operations with While Loop
        private static void ArrayOperationsWhileLoop(int[] array)
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Array operations with While Loop:");
            // Sum of all numbers
            int sum = 0;
            int i = 0;
            while (i < array.Length)
            {
                sum += array[i];
                i++;
            }
            Console.WriteLine($"Sum of all numbers: {sum}");
            // Biggest number
            int biggestNumber = int.MinValue;
            i = 0;
            while (i < array.Length)
            {
                if (array[i] > biggestNumber)
                {
                    biggestNumber = array[i];
                }
                i++;
            }
            Console.WriteLine($"Biggest number: {biggestNumber}");
            // Smallest number
            int smallestNumber = int.MaxValue;
            i = 0;
            while (i < array.Length)
            {
                if (array[i] < smallestNumber)
                {
                    smallestNumber = array[i];
                }
                i++;
            }
            Console.WriteLine($"Smallest number: {smallestNumber}");
            // Sum of min and max number in the array
            int sumMinMax = biggestNumber + smallestNumber;
            Console.WriteLine($"Sum of min and max number in the array: {sumMinMax}");
            // Average of all numbers
            int average = sum / array.Length;
            Console.WriteLine($"Average of all numbers: {average}");
            // Count of even numbers
            int countEvenNumbers = 0;
            i = 0;
            while (i < array.Length)
            {
                if (array[i] % 2 == 0)
                {
                    countEvenNumbers++;
                }
                i++;
            }
            Console.WriteLine($"Count of even numbers: {countEvenNumbers}");
            // Count of odd numbers
            int countOddNumbers = 0;
            i = 0;
            while (i < array.Length)
            {
                if (array[i] % 2 != 0)
                {
                    countOddNumbers++;
                }
                i++;
            }
            Console.WriteLine($"Count of odd numbers: {countOddNumbers}");
            Console.WriteLine("While operations finished");
        }
        // Array operations with Do While Loop
        private static void ArrayOperationsWithDoWhileLoop(int[] array)
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Array operations with Do While Loop:");
            // Sum of all numbers
            int sum = 0;
            int i = 0;
            do
            {
                sum += array[i];
                i++;
            } while (i < array.Length);
            Console.WriteLine($"Sum of all numbers: {sum}");
            // Biggest number
            int biggestNumber = int.MinValue;
            i = 0;
            do
            {
                if (array[i] > biggestNumber)
                {
                    biggestNumber = array[i];
                }
                i++;
            } while (i < array.Length);
            Console.WriteLine($"Biggest number: {biggestNumber}");
            // Smallest number
            int smallestNumber = int.MaxValue;
            i = 0;
            do
            {
                if (array[i] < smallestNumber)
                {
                    smallestNumber = array[i];
                }
                i++;
            } while (i < array.Length);
            Console.WriteLine($"Smallest number: {smallestNumber}");
            
            // Sum of min and max number in the array
            int sumMinMax = biggestNumber + smallestNumber;
            Console.WriteLine($"Sum of min and max number in the array: {sumMinMax}");
            // Average of all numbers
            int average = sum / array.Length;
            Console.WriteLine($"Average of all numbers: {average}");
            // Count of even numbers
            int countEvenNumbers = 0;
            i = 0;
            do
            {
                if (array[i] % 2 == 0)
                {
                    countEvenNumbers++;
                }
                i++;
            } while (i < array.Length);
            Console.WriteLine($"Count of even numbers: {countEvenNumbers}");
            // Count of odd numbers
            int countOddNumbers = 0;
            i = 0;
            do
            {
                if (array[i] % 2 != 0)
                {
                    countOddNumbers++;
                }
                i++;
            } while (i < array.Length);
            Console.WriteLine($"Count of odd numbers: {countOddNumbers}");
            Console.WriteLine("Do While operations finished");
        }
        // Array operations with For Each Loop
        private static void ArrayOperationsForEachLoop(int[] array)
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Array operations with For Each Loop:");
            // Sum of all numbers
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            Console.WriteLine($"Sum of all numbers: {sum}");
            // Biggest number
            int biggestNumber = int.MinValue;
            foreach (int item in array)
            {
                if (item > biggestNumber)
                {
                    biggestNumber = item;
                }
            }
            Console.WriteLine($"Biggest number: {biggestNumber}");
            // Smallest number
            int smallestNumber = int.MaxValue;
            foreach (int item in array)
            {
                if (item < smallestNumber)
                {
                    smallestNumber = item;
                }
            }
            Console.WriteLine($"Smallest number: {smallestNumber}");
            // Sum of min and max number in the array
            int sumMinMax = biggestNumber + smallestNumber;
            Console.WriteLine($"Sum of min and max number in the array: {sumMinMax}");
            // Average of all numbers
            int average = sum / array.Length;
            Console.WriteLine($"Average of all numbers: {average}");
            // Count of even numbers
            int countEvenNumbers = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    countEvenNumbers++;
                }
            }
            Console.WriteLine($"Count of even numbers: {countEvenNumbers}");
            // Count of odd numbers
            int countOddNumbers = 0;
            foreach (int item in array)
            {
                if (item % 2 != 0)
                {
                    countOddNumbers++;
                }
            }
            Console.WriteLine($"Count of odd numbers: {countOddNumbers}");
            Console.WriteLine("For Each operations finished");
        }
        // Array operations with Linq (Optional)
        private static void ArrayOperationsWithLinq(int[] array)
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Array operations with Linq:");
            // Sum of all numbers
            int sum = array.Sum();
            Console.WriteLine($"Sum of all numbers: {sum}");
            // Biggest number
            int biggestNumber = array.Max();
            Console.WriteLine($"Biggest number: {biggestNumber}");
            // Smallest number
            int smallestNumber = array.Min();
            Console.WriteLine($"Smallest number: {smallestNumber}");
            // Sum of min and max number in the array
            int sumMinMax = biggestNumber + smallestNumber;
            Console.WriteLine($"Sum of min and max number in the array: {sumMinMax}");
            // Average of all numbers
            int average = Convert.ToInt32(array.Average());
            Console.WriteLine($"Average of all numbers: {average}");
            // Count of even numbers
            int countEvenNumbers = array.Count(x => x % 2 == 0);
            Console.WriteLine($"Count of even numbers: {countEvenNumbers}");
            // Count of odd numbers
            int countOddNumbers = array.Count(x => x % 2 != 0);
            Console.WriteLine($"Count of odd numbers: {countOddNumbers}");
            Console.WriteLine("Linq operations finished");
        }
        // Array operations with Linq 2 (Optional)
        private static void ArrayOperationsWithLinq2(int[] array)
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Array operations with Linq 2:");
            // Sum of all numbers
            int sum = array.Aggregate((x, y) => x + y);
            Console.WriteLine($"Sum of all numbers: {sum}");
            // Biggest number
            int biggestNumber = array.Aggregate((x, y) => x > y ? x : y);
            Console.WriteLine($"Biggest number: {biggestNumber}");
            // Smallest number
            int smallestNumber = array.Aggregate((x, y) => x < y ? x : y);
            Console.WriteLine($"Smallest number: {smallestNumber}");
            // Sum of min and max number in the array
            int sumMinMax = biggestNumber + smallestNumber;
            Console.WriteLine($"Sum of min and max number in the array: {sumMinMax}");
            // Average of all numbers
            int average = Convert.ToInt32(array.Average());
            Console.WriteLine($"Average of all numbers: {average}");
            // Count of even numbers
            int countEvenNumbers = array.Count(x => x % 2 == 0);
            Console.WriteLine($"Count of even numbers: {countEvenNumbers}");
            // Count of odd numbers
            int countOddNumbers = array.Count(x => x % 2 != 0);
            Console.WriteLine($"Count of odd numbers: {countOddNumbers}");
            Console.WriteLine("Linq 2 operations finished");
        }
        // This method returns a random array with given size
        private static int[] GetRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }
        // This method prints an array
        private static void PrintArray(int[] array)
        {
            Console.WriteLine("Array:");
            // Iterate over the array and print each item
            foreach (int item in array)
            {
                // Print the item
                Console.Write($"{item} ");
            }
            // Print a new line
            Console.WriteLine();
        }

        // Main method
        private static void Main()
        {
            // Get a random array with size 15
            int[] array = GetRandomArray(15);
            // Print the array
            PrintArray(array);
            // Array operations with For Loop
            ArrayOperationsForLoop(array);
            // Array operations with While Loop
            ArrayOperationsWhileLoop(array);
            // Array operations with Do While Loop
            ArrayOperationsWithDoWhileLoop(array);
            // Array operations with For Each Loop
            ArrayOperationsForEachLoop(array);
            // Array operations with Linq (Optional)
            ArrayOperationsWithLinq(array);
            // Array operations with Linq 2 (Optional)
            ArrayOperationsWithLinq2(array);
        }
    }
}