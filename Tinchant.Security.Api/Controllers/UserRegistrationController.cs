using Microsoft.AspNetCore.Mvc;
using Tinchant.Security.Api.Models;
using Tinchant.Security.Domain.UserAggregation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tinchant.Security.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {        
        // POST api/<RegistrationController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] UserRegistrationRequest request, [FromServices]IUserRepository userRepository, [FromServices]IUserAggregationUoW userAggregationUoW, [FromServices]IRegistrationService registrationService)
        {
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);

            var user = new User(request, registrationService);
            await userRepository.AddAsync(user);
            await userAggregationUoW.CommitChangesAsync();
            return Ok(user);
        }
    }
}
