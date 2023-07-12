namespace ListOfSorting
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
        } // Конец метода QuickSort (Быстрой сортировки) ////////////////////////////////////////////////////////////////////////////////
        public static void BubbleSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - 1 - i; j++)
                {
                    if (inputArray[j] > inputArray[j+1]) 
                    {
                        Swap(ref  inputArray[j], ref inputArray[j+1]);
                    } // Конец условного оператора if
                }  // Конец вложенного цикла for
            }  // Конец цикла for
        } // Конец метода BubbleSort (Пузырьковой сортировки) ///////////////////////////////////////////////////////////////////////////
    } // Конец класса ListOfSortingAlgs
} // Конец пространства имен (модуля, библиотеки, коллекции классов, что-то такое) ListOfSorting