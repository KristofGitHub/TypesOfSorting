namespace ListOfSorting
{
    public class ListOfSortingAlgs
    {
        static void Swap(ref int leftValue, ref int rightValue)
        {
            int temp = leftValue;
            leftValue = rightValue;
            rightValue = temp;
        } // Конец метода Swap
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
                    } // Конец условного оператора if
                } // Конец цикла for
                pivotIndex++;
                Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]);
                return pivotIndex;
            } // Конец метода GetPivotIndex
            if (minIndex >= maxIndex) return;
            int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
            QuickSort(inputArray, minIndex, pivot - 1);
            QuickSort(inputArray, pivot + 1, maxIndex);
            return;
        } // Конец метода QuickSort (Быстрой сортировки)
        public static void BubbleSort(int[] inputArray)
        {
            
        } // Конец метода BubbleSort (Пузырьковой сортировки)
    } // Конец класса ListOfSortingAlgs
} // Конец пространства имен (модуля, библиотеки, коллекции классов, что-то такое) ListOfSorting