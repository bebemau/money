using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 6, 7, 8, 1, 3, 5, 2 };
            QuickSort(array, 0, array.Length - 1);

            // BinarySearch(3);
        }

        private static void QuickSort(int[] array, int startIndex, int endIndex)
        {
            if(endIndex > startIndex)
            {
                var partitionIndex = Partition(array, startIndex, endIndex);
                QuickSort(array, startIndex, partitionIndex-1);
                QuickSort(array, partitionIndex + 1, endIndex);
            }
            Console.WriteLine("Done");
        }

        private static int Partition(int[] array, int startIndex, int endIndex)
        {
            //this function will find the pivot and rearrange the array at the specified index
            var pivot = array[endIndex];
            var partitionIndex = startIndex;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (array[i] < pivot)
                {
                    var currentValue = array[i];
                    var partitionValue = array[partitionIndex];
                    array[i] = partitionValue;
                    array[partitionIndex] = currentValue;
                    partitionIndex++;
                }
            }
            var nextCurrentValue = array[partitionIndex];
            array[partitionIndex] = pivot;
            array[endIndex] = nextCurrentValue;
            return partitionIndex;
        }

        private int BinarySearch(int x)
        {
            int[] arr = new int[] { 1, 3, 5, 6, 7, 8 };
            Array.Sort(arr);

            var endPoint = arr.Length - 1;
            var startPoint = 0;
            int midPoint;
            int midValue;

            while (endPoint > startPoint)
            {
                midPoint = (endPoint - startPoint) / 2;
                midValue = arr[midPoint];

                if (midValue == x)
                {
                    return midValue;
                }
                else if (midValue > x)
                {
                    endPoint = midPoint;
                }
                else if (midValue < x)
                    startPoint = midPoint;
            }

            return -1;
        }

    }
}
