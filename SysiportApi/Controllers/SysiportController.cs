using Microsoft.AspNetCore.Mvc;
using SysiportApi.Dto;
using SysiportApi.Repositories;
using SysiportData;

namespace SysiportApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SysiportController(SysiportDbContext dbContext) : ControllerBase
    {
        private readonly OrganizationRepository _organizationRepository = new(dbContext);
        private readonly UserRepository _userRepository = new(dbContext);


        [HttpPost]
        public async Task<IActionResult> Organization(OrganizationDto data)
        {
            try
            {
                await _organizationRepository.AddOrganization(data);
            }
            catch (Exception e)
            {
                return BadRequest($"Failed to register new organization. Exception: {e}");
            }
            return Ok("New organization registered");
        }

        [HttpGet]
        public async Task<IActionResult> Organization(int id)
        {
            try
            {
                var responseData = await _organizationRepository.GetOrganization(id);
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return BadRequest($"Failed getting organization with id: {id}. {Environment.NewLine}Exception: {e}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserDto data)
        {
            try
            {
                int userId = await _userRepository.AddUser(data, data.IsAdmin);

                if (userId > 0)
                    return Ok($"New user added with id: {userId}");
                else
                    return BadRequest("Failed adding new user");
            }
            catch (Exception e)
            {
                return BadRequest($"Error when adding new user. Exception: {e}");
            }
        }
    }
}
