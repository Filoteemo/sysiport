namespace SysiportApi.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int TeamId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Created {get; set;}
        public DateTime Updated {get; set;}
        public bool IsAdmin { get; set;}
    }
}
