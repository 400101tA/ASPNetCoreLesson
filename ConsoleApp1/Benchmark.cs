using BenchmarkDotNet.Attributes;

namespace ConsoleApp1;

[MemoryDiagnoser()]
[RankColumn()]
public class Benchmark
{

    public IList<Test> Tests { get; set; } = new List<Test>();
    [GlobalSetup]
    public void Setup()
    {
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
        Tests.Add(new Test(){Title = "trer", Name = "sdfsd"});
    }

    [Benchmark]
    public List<Test2> Foreach()
    {
        var test2s = new List<Test2>();
        for (var index = 0; index < Tests.Count; index++)
        {
            var test = Tests[index];
            test2s.Add(new Test2() { Name = test.Name, Title = test.Title });
        }

        return test2s;
    }

    [Benchmark]
    public List<Test2> Select()
    {
        var test2s = Tests.Select(test => new Test2(){Name = test.Name,Title = test.Title}).ToList();
        return test2s;
    }
}

public class Test
{
    public string Name { get; set; }
    public string Title { get; set; }
}

public class Test2
{
    public string Name { get; set; }
    public string Title { get; set; }
}