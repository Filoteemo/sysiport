namespace SysiportApi.Dto
{
    public class OrganizationDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Subscription { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
    public enum SubscriptionTypes
    {
        Free,
        Premium,
        Enterprise
    }
}
