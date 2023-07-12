using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;
using ListOfSorting;

namespace TrueCode
{
    [MemoryDiagnoser]
    [RankColumn]
    public class ListOfSortingBenchmark
    {
        private static readonly int[] arr = new int[1_000];
        private static readonly Random _rand = new Random();
        static ListOfSortingBenchmark()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = _rand.Next(0, 1_000_000);
            }
        }
        public int[] GetArr()
        {
            var res = new int[arr.Length];
            Array.Copy(arr, res, arr.Length);
            return res;
        }
        [Benchmark]
        public void TestQuickSort()
        {
            int i = 1;
            ++i;
            var testArr = GetArr();
            ListOfSortingAlgs.QuickSort(testArr.Arr, 0, testArr.Length - 1);
        }
        [Benchmark]
        public void TestBubbleSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.BubbleSort(testArr);
        }
        [Benchmark]
        public void TestSelectionSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.SelectionSortSort(testArr);
        }
        [Benchmark]
        public void TestCountingSort()
        {
            var testArr = GetArr();
            ListOfSortingAlgs.CountingSort(testArr);
        }
    }
}