namespace SysiportData.Models;
public class Organization
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public SubscriptionTypes Subscription { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}

public enum SubscriptionTypes
{
    Free,
    Premium,
    Enterprise
}