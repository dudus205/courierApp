using System.Threading.Tasks;
using DistributedTravelingSalesman.Domain;
using DistributedTravelingSalesman.Dto;
using DistributedTravellingSalesman.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DistributedTravelingSalesman.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    public TravellingSalesmanDbContext Context { get; }

    public UserController(TravellingSalesmanDbContext context)
    {
        Context = context;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto data)
    {
        if (data.Password != data.Password2)
            return BadRequest("Provided passwords do not match");
        
        var user = new UserEntity
        {
            Email = data.Email
        };

        user.SetPassword(data.Password);

        await Context.Users.AddAsync(user);

        await Context.SaveChangesAsync();

        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto data)
    {
        var user = await Context.Users.FirstOrDefaultAsync(x => x.Email == data.Email);

        if (user != null && user.CheckPassword(data.Password))
        {
            return Ok();
        }
        
        return BadRequest();
    }
}