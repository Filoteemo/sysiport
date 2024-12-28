namespace SysiportData.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public DateTime Expiration { get; set; }
        public bool ShouldRenew { get; set; }
        public DateTime Renewal { get; set; }
        public bool Canceled { get; set; }
    }
}
