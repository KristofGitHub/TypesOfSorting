```

BenchmarkDotNet v0.13.6, Windows 10 (10.0.19044.3086/21H2/November2021Update)
Intel Core i7-10870H CPU 2.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|            Method |        Mean |     Error |   StdDev |      Median | Rank |     Gen0 |     Gen1 |     Gen2 |  Allocated |
|------------------ |------------:|----------:|---------:|------------:|-----:|---------:|---------:|---------:|-----------:|
|     TestQuickSort |    61.03 μs |  8.399 μs | 24.76 μs |    73.20 μs |    1 |   0.3662 |        - |        - |    3.93 KB |
|    TestBubbleSort |   843.59 μs | 26.968 μs | 75.18 μs |   825.33 μs |    3 |        - |        - |        - |    3.93 KB |
| TestSelectionSort |   364.16 μs | 16.847 μs | 49.41 μs |   350.02 μs |    2 |        - |        - |        - |    3.93 KB |
|  TestCountingSort | 1,841.24 μs | 27.068 μs | 25.32 μs | 1,845.75 μs |    4 | 998.0469 | 998.0469 | 998.0469 | 3893.67 KB |
