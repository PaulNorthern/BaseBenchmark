``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Xeon CPU E3-1230 V2 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|        Method | val |      Mean |    Error |   StdDev |    Median |  Gen 0 | Allocated |
|-------------- |---- |----------:|---------:|---------:|----------:|-------:|----------:|
|    CalcStruct |  10 |  18.36 ns | 0.395 ns | 0.850 ns |  18.06 ns | 0.0153 |      64 B |
| CalcStructRef |  10 |  17.88 ns | 0.347 ns | 0.325 ns |  17.81 ns | 0.0153 |      64 B |
|     CalcClass |  10 | 117.10 ns | 2.182 ns | 2.041 ns | 116.76 ns | 0.0823 |     344 B |
