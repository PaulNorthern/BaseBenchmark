using BenchmarkDotNet.Attributes;

namespace BaseBenchmark.ClassStructTest;

public struct MyStruct
{
    public int Value;
}

public sealed class MyClass
{
    public int Value;
}

[MemoryDiagnoser()]
public sealed class ClassStructExample
{
    [Benchmark]
    [Arguments(10)]
    public void CalcStruct(int val)
    {
        var arr = new MyStruct[val];

        for (int i = 0; i < arr.Length; i++)
        {
            var st = new MyStruct();
            PrimitiveCalcStruct(st);
            arr[i] = st;
        }
    }

    private void PrimitiveCalcStruct(MyStruct st)
    {
        st.Value = 5;
    }
    
    [Benchmark]
    [Arguments(10)]
    public void CalcStructRef(int val)
    {
        var arr = new MyStruct[val];

        for (int i = 0; i < arr.Length; i++)
        {
            var st = new MyStruct();
            PrimitiveCalcStructRef(ref st);
            arr[i] = st;
        }
    }

    private void PrimitiveCalcStructRef(ref MyStruct st)
    {
        st.Value = 5;
    }
    
    [Benchmark]
    [Arguments(10)]
    public void CalcClass(int val)
    {
        var arr = new MyClass[val];

        for (int i = 0; i < arr.Length; i++)
        {
            var st = new MyClass();
            PrimitiveCalCclass(st);
            arr[i] = st;
        }
    }

    private void PrimitiveCalCclass(MyClass st)
    {
        st.Value = 5;
    }
}