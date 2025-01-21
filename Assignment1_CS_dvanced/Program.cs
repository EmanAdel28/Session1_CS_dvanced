namespace Assignment1_CS_dvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
            //And implement the code of this optimized bubble sort algorithm
            int[] arr = { 3, 6, 2, 7, 5, 8 };
            Helper<int>.BubbleSort(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
