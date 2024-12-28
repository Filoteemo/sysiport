namespace SysiportData.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public required Project Project { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
