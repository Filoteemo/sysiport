using SysiportApi.Dto;
using SysiportData;
using SysiportData.Models;

namespace SysiportApi.Repositories
{
    public class UserRepository(SysiportDbContext db)
    {
        private readonly SysiportDbContext _sysiportDb = db;
        public async Task<int> AddUser(UserDto user, bool isAdmin = false)
        {
            User newUser = new()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                OrganizationId = user.OrganizationId
            };

            if (!isAdmin && user.TeamId == 0)
                throw new Exception("Failed adding new user, missing teamId in request.");
            if (isAdmin)
                newUser.IsAdmin = true;

            _sysiportDb.Users.Add(newUser);
            await _sysiportDb.SaveChangesAsync();
            return newUser.Id;
        }
    }
}
