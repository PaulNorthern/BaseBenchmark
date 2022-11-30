using BenchmarkDotNet.Attributes;

namespace BaseBenchmark.Collection;

[MemoryDiagnoser()]
public class CollectionsExample
{
    [Benchmark]
    [Arguments(100_000)]
    public void SingleStreamForeach(int val)
    {
        var intList = Enumerable.Range(1, val).ToList();
        foreach (var num in intList)
        {
            MultiplyByTwo(num);
        }
    }
    
    [Benchmark]
    [Arguments(100_000)]
    public void ParallelStreamForeach(int val)
    {
        var intList = Enumerable.Range(1, val).ToList();
        Parallel.ForEach(intList, num =>
        {
            MultiplyByTwo(num);
        });

    }

    private static int MultiplyByTwo(int i) => i * 2;
}