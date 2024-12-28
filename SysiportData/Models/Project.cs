
namespace SysiportData.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public required Organization Organization { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int TeamId { get; set; }
        public required Team Team { get; set; }
        public ICollection<Resource>? Resources { get; set; }
        public ICollection<Event>? Events { get; set; }
        public ICollection<Faq>? Faqs { get; set; }
    }
}
