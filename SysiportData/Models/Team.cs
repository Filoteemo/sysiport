namespace SysiportData.Models;

public class Team
{
    public int Id { get; set; }
    public required Organization Organization { get; set; }
    public int OrganizationId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public ICollection<User>? Users { get; set; } = [];
    public ICollection<Project>? Projects { get; set; } = [];
}
