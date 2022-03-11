using System;

namespace Sorting
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 9, 4, 6, 8, 9, 32, 2, 1, -32, 2132 };
        //4, 9, 6, 8, 9, 32, 2, 1, -32, 2132
        //2, 9, 6, 8, 9, 32, 4, 1, -32, 2132
        //1, 9, 6, 8, 9, 32, 4, 2, -32, 2132
        //-32, 9, 6, 8, 9, 32, 4, 2, 1, 2132
            int[] numbers2 = { 9, 4, 4324, 67896, -54 };
            string[] words = new string[] { "Ham", "Cram", "Wood", "Weez" };
            ProvideData provideData = new ProvideData();
            int[] result = provideData.EfficientBubbleSort(numbers);
            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(numbers2);
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i] + " ");
            }
            //calling the Reverse from Array Object
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();
            //calling sort function from the Array object
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)

            {
                Console.Write(words[i] + " ");
            }

            int[] inputArray = { 1, 3, 8, 14, 15 };
            Console.WriteLine("Index position of the searched key is:" + ProvideData.BinarySearch(inputArray, 14));
            
        }

    }
}
