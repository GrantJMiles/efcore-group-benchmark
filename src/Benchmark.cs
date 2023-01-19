namespace src;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;

public class EfBenchmark
{
    private readonly RepoService _serviceRepo;
    private readonly Consumer _consumer = new Consumer();
    public EfBenchmark() => _serviceRepo = new RepoService();

    // [Benchmark]
    // public async Task Repo() => (await _serviceRepo.GetServiceCountsFromRepoAsync()).Consume(_consumer);
    [Benchmark]
    public async Task Service() => (await _serviceRepo.GetServiceCountsFromServiceAsync()).Consume(_consumer);

}