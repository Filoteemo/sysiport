using SysiportApi.Dto;
using SysiportData;
using SysiportData.Models;

namespace SysiportApi.Repositories
{
    public class OrganizationRepository(SysiportDbContext db)
    {
        private readonly SysiportDbContext _sysiportDb = db;
        public async Task AddOrganization(OrganizationDto data)
        {
            var subscriptionType = data.Subscription switch
            {
                "Free" => SysiportData.Models.SubscriptionTypes.Free,
                "Premium" => SysiportData.Models.SubscriptionTypes.Premium,
                "Enterprise" => SysiportData.Models.SubscriptionTypes.Enterprise,
                _ => SysiportData.Models.SubscriptionTypes.Free
            };

            _sysiportDb.Organizations.Add(new Organization
            {
                Id = data.Id,
                Name = data.Name,
                Subscription = subscriptionType,
                Created = DateTime.UtcNow,
            });

            await _sysiportDb.SaveChangesAsync();
        }

        public async Task<OrganizationDto?> GetOrganization(int id)
        {
            OrganizationDto? result = null;
            var organization = await _sysiportDb.Organizations.FindAsync(id);
            if (organization != null)
            {
                result = new OrganizationDto()
                {
                    Id = organization.Id,
                    Name = organization.Name,
                    Subscription = organization.Subscription.ToString(),
                    Created = organization.Created,
                    Updated = organization.Updated,
                };
            }
            return result;
        }
    }
}
