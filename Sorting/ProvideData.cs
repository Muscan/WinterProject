using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class ProvideData
    {
        //most inefficient way of sort
        public int[] SortArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for(int j= i+1; j<numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        int aux;
                        aux = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = aux;
                    }
                }
            }
            return numbers;
        }
        //5, 3, 7, 18, 10
        //3, 5, 7, 18, 10
        //3, 5, 7, 10, 18
        //bubble sort
        public int[] EfficientBubbleSort(int[] nr)
        {
            bool swapped = false;
            int n= nr.Length;
            do
            {
                swapped = false;
                for(int i=0; i<n-1; i++)
                {
                    if(nr[i] > nr[i+1])
                    {
                        int aux;
                        aux = nr[i];
                        nr[i] = nr[i+1];
                        nr[i + 1] = aux;
                        swapped = true;
                    }
                }
                n--;
            }while(swapped == true);
            return nr;
        }
        public static int BinarySearch(int[] inputArray, int key)
        {   
            //key = 14
            //                     0  1  2  3  4
            //int[] inputArray = { 1, 3, 8, 14, 15 };
            //min = 0, max - 4(index)
            int min = 0;
            //max = 5 elem. -1 = 4 (return indice ultimul element din sir)
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;//4/2 = 2
                if (key == inputArray[mid])
                {
                    return mid;
                }
                //
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1; //min=2+1=3
                }
            }
            return -1;//not found
        }
        

    }




    
}
