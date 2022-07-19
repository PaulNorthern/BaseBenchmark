using BenchmarkDotNet.Attributes;

namespace BaseBenchmark.LinqExample;

[MemoryDiagnoser()]
public sealed class LinqExtensionAny
{
    public List<User> _users = new List<User>();

    [GlobalSetup]
    public void GlobalSetup()
    {
        for (int i = 0; i < 10; i++)
        {
            _users.Add(new User());
        }
    }

    [Benchmark]
    public bool ComputeCount()
    {
        return _users.Count > 0;
    }
    
    [Benchmark]
    public bool AnyCount()
    {
        return _users.Any();
    }
}