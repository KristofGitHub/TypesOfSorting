```

BenchmarkDotNet v0.13.6, Windows 10 (10.0.19044.3086/21H2/November2021Update)
Intel Core i7-10870H CPU 2.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|            Method |        Mean |     Error |    StdDev | Rank |     Gen0 |     Gen1 |     Gen2 |  Allocated |
|------------------ |------------:|----------:|----------:|-----:|---------:|---------:|---------:|-----------:|
|     TestQuickSort |    36.43 μs |  0.723 μs |  1.525 μs |    1 |   0.3662 |        - |        - |    3.93 KB |
|    TestBubbleSort |   761.63 μs | 14.765 μs | 18.133 μs |    3 |        - |        - |        - |    3.93 KB |
| TestSelectionSort |   294.64 μs |  4.739 μs |  4.201 μs |    2 |        - |        - |        - |    3.93 KB |
|  TestCountingSort | 1,737.31 μs | 32.263 μs | 28.601 μs |    4 | 998.0469 | 998.0469 | 998.0469 | 3897.36 KB |
