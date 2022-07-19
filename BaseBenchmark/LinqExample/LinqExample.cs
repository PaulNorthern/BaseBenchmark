using BenchmarkDotNet.Attributes;

namespace BaseBenchmark.LinqExample;

public class User
{
    public int Age;
}

[MemoryDiagnoser()]
public sealed class LinqExample
{
    public List<User> _users = new List<User>();

    [GlobalSetup]
    public void GlobalSetup()
    {
        for (int i = 0; i < 20; i++)
        {
            _users.Add(new User());
        }
    }

    [Benchmark]
    public int ForLoopExample()
    {
        var sum = 0;

        for (int i = 0; i < 20; i++)
        {
            sum += _users[i].Age;
        }
        
        return sum / _users.Count;
    }
    
    [Benchmark]
    public int ForeachLoopExample()
    {
        var sum = 0;

        foreach (var user in _users)
        {
            sum += user.Age;
        }

        return sum / _users.Count;
    }
    
    [Benchmark]
    public int LinqLoopExample()
    {
        var sum = _users.Sum(user => user.Age);

        return sum / _users.Count;
    }
}