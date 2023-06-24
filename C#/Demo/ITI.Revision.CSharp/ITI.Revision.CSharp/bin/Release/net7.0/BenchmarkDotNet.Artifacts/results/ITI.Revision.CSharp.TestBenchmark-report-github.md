``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3086/22H2/2022Update)
Intel Core i5-4210U CPU 1.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                         Method |      Mean |    Error |   StdDev |
|------------------------------- |----------:|---------:|---------:|
|        PrintPatternUsingString | 216.38 ns | 3.627 ns | 3.392 ns |
| PrintPatternUsingStringBuilder |  79.39 ns | 1.461 ns | 1.220 ns |
