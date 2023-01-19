using Microsoft.EntityFrameworkCore;

namespace src;

public class RepoService
{
    public async Task<IEnumerable<ServiceCount>> GetServiceCountsFromRepoAsync()
    {
        using var ctx = new ExampleContext();
        return await ctx.Logs
            .GroupBy(g => g.Service.Name)
            .Select(s => new ServiceCount()
            {
                Service = s.Key,
                Count = s.Count()
            }).ToListAsync();
    }
    public async Task<IEnumerable<ServiceCount>> GetServiceCountsFromServiceAsync()
    {
        using var ctx = new ExampleContext();
        var logs = await ctx.Logs
            .ToListAsync();
        return logs
            .GroupBy(g => g?.Service?.Name)
            .Select(s => new ServiceCount()
            {
                Service = s.Key,
                Count = s.Count()
            }).ToList();
    }
}