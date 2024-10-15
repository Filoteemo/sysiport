
namespace SysiportData.Models
{
    public class Project
    {
        public int Id { get; set; }
        public required Organization Organization { get; set; }
        public int OrganizationId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public ICollection<Team>? Teams { get; set; }
    }
}
