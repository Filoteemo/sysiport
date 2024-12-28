namespace SysiportData.Models
{
    public class User
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; }
        public bool IsAdmin { get; set; } = false;
        public ICollection<Team>? Teams { get; set; } = [];
    }
}
