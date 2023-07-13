using BenchmarkDotNet.Running;
using TrueCode;

namespace TrueCode
{
    class Program 
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ListOfSortingBenchmark>();
            Console.WriteLine("Для завершения программы нажмите 0.");
            int stopCode = 1;
            while (stopCode == 1 ){stopCode = Convert.ToInt32(Console.Read());}
        }
    }
    
} // Конец пространства имен (модуля, библиотеки, коллекции классов, что-то такое) ListOfSorting