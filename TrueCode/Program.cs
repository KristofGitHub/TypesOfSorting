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
                int PivotIndex = minIndex - 1;
                for(int i = minIndex; i <= maxIndex; i++)
                {
                    if(inputArray[i] < inputArray[maxIndex]) 
                    {

                    } // Конец условного оператора if
                } // Конец цикла for
            } // Конец метода GetPivotIndex
        } // Конец метода QuickSort

    } // Конец класса ListOfSortingAlgs
} // Конец пространства имен (модуля, библиотеки, коллекции классов) ListOfSorting