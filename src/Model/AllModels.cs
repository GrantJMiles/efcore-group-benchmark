namespace src;

public class Service
{
    public int Id {get; set;}
    public string Name {get;set;}

    public ICollection<MyLogs> MyLogs {get; set;}
}

public class MessageProvider
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<MyLogs> Logs {get; set;}
}

public class MyLogs 
{
    public int Id { get; set; }
    public string ReferenceId { get; set; }
    public string LogMessage { get; set; }
    public DateTime SentAt { get; set; }

    public MessageProvider MessageProvider { get; set; }
    public Service Service { get; set; }

}


public class ServiceCount
{
    public string Service { get; set; }
    public int Count { get; set; }
}