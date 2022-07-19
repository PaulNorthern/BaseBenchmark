``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Xeon CPU E3-1230 V2 3.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|        Method | val |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|-------------- |---- |----------:|---------:|---------:|-------:|----------:|
|    CalcStruct |  10 |  17.58 ns | 0.376 ns | 0.418 ns | 0.0153 |      64 B |
| CalcStructRef |  10 |  18.53 ns | 0.403 ns | 0.661 ns | 0.0153 |      64 B |
|     CalcClass |  10 | 118.80 ns | 2.393 ns | 4.254 ns | 0.0823 |     344 B |
