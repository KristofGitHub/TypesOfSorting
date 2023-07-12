using BenchmarkDotNet.Running;
using TrueCode;

namespace TrueCode
{
    class Program 
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ListOfSortingBenchmark>();
        }
    }
    
} // Конец пространства имен (модуля, библиотеки, коллекции классов, что-то такое) ListOfSorting