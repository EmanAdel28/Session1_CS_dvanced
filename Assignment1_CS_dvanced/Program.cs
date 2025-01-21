using System.Security.Cryptography;

namespace Assignment1_CS_dvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
            //And implement the code of this optimized bubble sort algorithm
            //int[] arr = { 3, 6, 2, 7, 5, 8 };
            //Helper<int>.BubbleSort(arr);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q2
            //create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
            //The range should support basic operations such as checking if a value is within the range and determining
            //the length of the range.
            //Requirements:
            //1. Create a generic class named Range<T> where T represents the type of values.
            //2. Implement a constructor that takes the minimum and maximum values to define the range.
            //3. Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            //4. Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            //5. Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

            // Create a range of integers
            Range<int> intRange = new Range<int>(10, 20);

            Console.WriteLine(intRange); // Output: Range: [10, 20]
            Console.WriteLine("15 is in range: " + intRange.IsInRange(15)); // Output: True
            Console.WriteLine("25 is in range: " + intRange.IsInRange(25)); // Output: False
            Console.WriteLine("Length of range: " + intRange.GetRangeLength()); // Output: 10
            #endregion
        }
    }
}
