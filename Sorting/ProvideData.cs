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
    }

    
}
