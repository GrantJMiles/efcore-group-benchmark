namespace src;

public class Seed 
{
    public async Task RunDeleteCreateAsync()
    {
        using var ctx = new ExampleContext();
        var _bf = new Bogus.Faker();

        await ctx.Database.EnsureDeletedAsync();
        await ctx.Database.EnsureCreatedAsync();

        var seedServices = new List<Service>()
        {
            new Service() {Name = "Service One"},
            new Service() {Name = "Service Two"},
            new Service() {Name = "Service Three"}
        };

        var provider = new MessageProvider() {Name = "Grants SMS Sender" };

        var seedLogs = new List<MyLogs>();
        for (int i = 0; i < 1000; i++)
        {
            seedLogs.Add(new MyLogs() 
            { 
                LogMessage = _bf.Lorem.Sentence(wordCount:15), 
                MessageProvider = provider,
                ReferenceId = _bf.Random.Uuid().ToString(),
                SentAt = _bf.Date.Between(DateTime.Now.AddMonths(-6), DateTime.Now),
                Service = _bf.PickRandom(seedServices)
            });
        }

        await ctx.AddRangeAsync(seedLogs);
        await ctx.SaveChangesAsync();
    }
}