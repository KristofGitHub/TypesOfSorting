using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCode
{
    public class ListOfSortingAlgs
    {
        // Пишем метод Swap, который будет менять местами две переменные: 
        // если x = 2, а y = 5, то метод выдаст x = 5 и y = 2. Этот метод пригодится при реализации алгоритма быстрой сортировки.
        static void Swap(ref int leftValue, ref int rightValue)
        {
            int temp = leftValue;
            leftValue = rightValue;
            rightValue = temp;
        } // Конец метода Swap ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void QuickSort(int[] inputArray, int minIndex, int maxIndex)
        {
            static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
            {
                int pivotIndex = minIndex - 1;
                for (int i = minIndex; i <= maxIndex; i++)
                {
                    if (inputArray[i] < inputArray[maxIndex]) 
                    {
                        pivotIndex++;
                        Swap(ref inputArray[i], ref inputArray[pivotIndex]);
                    }
                }
                pivotIndex++;
                Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]);
                return pivotIndex;
            } // Конец метода GetPivotIndex
            if (minIndex >= maxIndex) return;
            int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
            QuickSort(inputArray, minIndex, pivot - 1);
            QuickSort(inputArray, pivot + 1, maxIndex);
            return;
        } // Конец метода QuickSort (Быстрой сортировки) ////////////////////////////////////////////////////////////////////////////////
        public static void BubbleSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - 1 - i; j++)
                {
                    if (inputArray[j] > inputArray[j+1]) 
                    {
                        Swap(ref inputArray[j], ref inputArray[j+1]);
                    }
                }
            }
        } // Конец метода BubbleSort (Пузырьковой сортировки) ///////////////////////////////////////////////////////////////////////////
        public static void SelectionSort(int[] inputArray)
        {
            int min = i;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[min])
                    {
                        min = j;
                    }
                }
            }
        } // Конец метода SelectionSort (Сортировки выбором) ///////////////////////////////////////////////////////////////////////////
        public static void CountingSort(int[] inputArray)
        {
            var min = inputArray[0];
            var max = inputArray[0];
            foreach (int element in inputArray)
            {
                if (element > max) {max = element;}
                else if (element < min) {min = element;}
            }
            var correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;
            var count = new int[max+1];
            for (var i = 0; i < inputArray.Length; i++) {count[inputArray[i] + correctionFactor]++;}
            var index = 0;
            for (var i = 0; i < count.Length; i++) 
            {
                for (var j = 0; j <count[i]; j++) 
                {
                    inputArray[index] = i - correctionFactor;
                    index++;
                }
            }
            return;
        } // Конец метода CountingSort ////////////////////////////////////////////////////////////////////////////////////////////////
    } // Конец класса ListOfSortingAlgs
}