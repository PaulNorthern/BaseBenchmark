``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Xeon CPU E3-1230 V2 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|             Method |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|------------------- |----------:|---------:|---------:|-------:|----------:|
|     ForLoopExample |  19.63 ns | 0.274 ns | 0.243 ns |      - |         - |
| ForeachLoopExample |  42.32 ns | 0.879 ns | 1.203 ns |      - |         - |
|    LinqLoopExample | 330.34 ns | 3.300 ns | 2.756 ns | 0.0095 |      40 B |
