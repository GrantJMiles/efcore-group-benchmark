// See https://aka.ms/new-console-template for more information
using src;
using BenchmarkDotNet.Running;
Console.WriteLine("Hello, World!");

var seed = new Seed();
await seed.RunDeleteCreateAsync();


BenchmarkRunner.Run<EfBenchmark>();