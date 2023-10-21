``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.3.1 (22E261) [Darwin 22.4.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 6.0.16 (6.0.1623.17311), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), Arm64 RyuJIT AdvSIMD


```
|  Method |     Mean |     Error |    StdDev | Rank |   Gen0 | Allocated |
|-------- |---------:|----------:|----------:|-----:|-------:|----------:|
| Foreach | 2.171 μs | 0.0104 μs | 0.0097 μs |    2 | 2.0866 |   4.27 KB |
|  Select | 1.952 μs | 0.0383 μs | 0.0441 μs |    1 | 1.3618 |   2.78 KB |
