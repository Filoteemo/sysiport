using Microsoft.EntityFrameworkCore;
using SysiportData.Models;

namespace SysiportData
{
    public class SysiportDbContext : DbContext
    {
        public SysiportDbContext(DbContextOptions<SysiportDbContext> options) : base(options) 
        {}

        public DbSet<Organization> Organizations { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Subscription> Subscriptions { get; set; } = null!;
        public DbSet<Resource> Resources { get; set; } = null!; 
        public DbSet<Event> Events { get; set; } = null!; 
        public DbSet<Faq> Faqs { get; set; } = null!; 
    }
}
