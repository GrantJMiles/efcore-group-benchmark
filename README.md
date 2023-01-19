# efcore-group-benchmark
Simple project to demonstrate a simple grouping query and its cost against evaluating on server/client


## Results from run

```sh
dotnet run -c Release
```

```zsh
// Benchmark Process 24954 has exited with code 0.

Mean = 14.629 ms, StdErr = 0.250 ms (1.71%), N = 98, StdDev = 2.479 ms
Min = 10.893 ms, Q1 = 12.525 ms, Median = 14.436 ms, Q3 = 15.993 ms, Max = 21.296 ms
IQR = 3.468 ms, LowerFence = 7.323 ms, UpperFence = 21.195 ms
ConfidenceInterval = [13.779 ms; 15.478 ms] (CI 99.9%), Margin = 0.850 ms (5.81% of Mean)
Skewness = 0.67, Kurtosis = 2.95, MValue = 2.88

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2023-01-19 22:53 (0h 0m from now) **
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts/results/src.EfBenchmark-report.csv
  BenchmarkDotNet.Artifacts/results/src.EfBenchmark-report-github.md
  BenchmarkDotNet.Artifacts/results/src.EfBenchmark-report.html

// * Detailed results *
EfBenchmark.Repo: DefaultJob
Runtime = .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.910 ms, StdErr = 0.029 ms (1.51%), N = 98, StdDev = 0.285 ms
Min = 1.563 ms, Q1 = 1.709 ms, Median = 1.793 ms, Q3 = 2.107 ms, Max = 2.681 ms
IQR = 0.398 ms, LowerFence = 1.113 ms, UpperFence = 2.703 ms
ConfidenceInterval = [1.812 ms; 2.008 ms] (CI 99.9%), Margin = 0.098 ms (5.12% of Mean)
Skewness = 1.1, Kurtosis = 3.02, MValue = 2.96
-------------------- Histogram --------------------
[1.534 ms ; 1.678 ms) | @@@@@@@@@@@@
[1.678 ms ; 1.840 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.840 ms ; 1.991 ms) | @@@@@@@@@@@
[1.991 ms ; 2.063 ms) | 
[2.063 ms ; 2.226 ms) | @@@@@@@@@@@
[2.226 ms ; 2.346 ms) | @@
[2.346 ms ; 2.509 ms) | @@@@@@@@@@@
[2.509 ms ; 2.574 ms) | 
[2.574 ms ; 2.762 ms) | @@@
---------------------------------------------------

EfBenchmark.Service: DefaultJob
Runtime = .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 14.629 ms, StdErr = 0.250 ms (1.71%), N = 98, StdDev = 2.479 ms
Min = 10.893 ms, Q1 = 12.525 ms, Median = 14.436 ms, Q3 = 15.993 ms, Max = 21.296 ms
IQR = 3.468 ms, LowerFence = 7.323 ms, UpperFence = 21.195 ms
ConfidenceInterval = [13.779 ms; 15.478 ms] (CI 99.9%), Margin = 0.850 ms (5.81% of Mean)
Skewness = 0.67, Kurtosis = 2.95, MValue = 2.88
-------------------- Histogram --------------------
[10.187 ms ; 11.739 ms) | @@@@@@@@@
[11.739 ms ; 13.151 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@
[13.151 ms ; 14.548 ms) | @@@@@@@@@@@@@@@@
[14.548 ms ; 16.231 ms) | @@@@@@@@@@@@@@@@@@@@@@@@
[16.231 ms ; 17.642 ms) | @@@@@@@@@@@@@@
[17.642 ms ; 18.898 ms) | @@@
[18.898 ms ; 19.994 ms) | @@
[19.994 ms ; 21.405 ms) | @@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.4, OS=debian 11 (container)
Intel Core i5-1035G1 CPU 1.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


|  Method |      Mean |     Error |    StdDev |    Median |
|-------- |----------:|----------:|----------:|----------:|
|    Repo |  1.910 ms | 0.0979 ms | 0.2854 ms |  1.793 ms |
| Service | 14.629 ms | 0.8498 ms | 2.4790 ms | 14.436 ms |

// * Warnings *
MultimodalDistribution
  EfBenchmark.Repo: Default    -> It seems that the distribution can have several modes (mValue = 2.96)
  EfBenchmark.Service: Default -> It seems that the distribution can have several modes (mValue = 2.88)

// * Hints *
Outliers
  EfBenchmark.Repo: Default    -> 2 outliers were removed (2.83 ms, 2.86 ms)
  EfBenchmark.Service: Default -> 2 outliers were removed (23.40 ms, 24.33 ms)

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  Median : Value separating the higher half of all measurements (50th percentile)
  1 ms   : 1 Millisecond (0.001 sec)

// ***** BenchmarkRunner: End *****
Run time: 00:02:46 (166.16 sec), executed benchmarks: 2

Global total time: 00:02:54 (174.68 sec), executed benchmarks: 2
// * Artifacts cleanup *
```
