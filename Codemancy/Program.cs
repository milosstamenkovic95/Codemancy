using System;
using System.Collections.Generic;

namespace Codemancy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input dimension of the array: " + Environment.NewLine);
            int arrayDimension = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayDimension];
            Console.WriteLine(Environment.NewLine + "Please input elements of the array: " + Environment.NewLine);
            for(int i = 0; i < arrayDimension; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            array = mergeSort(array);
            Console.WriteLine(Environment.NewLine + "Sorted array: " + Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        private static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            if (array.Length <= 1)
                return array;

            int midPoint = array.Length / 2;

            left = new int[midPoint];

            if (array.Length % 2 == 0)
                right = new int[midPoint];
            else
                right = new int[midPoint + 1];

            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
 
            int x = 0;

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }

            left = mergeSort(left);
            right = mergeSort(right);
            result = merge(left, right);
            return result;
        }

        private static int[] merge(int[] left, int[] right)
        {
            int resultLength = left.Length + right.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
