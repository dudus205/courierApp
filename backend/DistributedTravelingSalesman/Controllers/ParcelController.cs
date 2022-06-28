using System.Threading.Tasks;
using DistributedTravelingSalesman.Domain;
using DistributedTravelingSalesman.Dto;
using DistributedTravellingSalesman.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DistributedTravelingSalesman.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParcelController : ControllerBase
{
    public ParcelController(TravellingSalesmanDbContext context)
    {
        Context = context;
    }

    public TravellingSalesmanDbContext Context { get; }

    [HttpGet]
    public async Task<IActionResult> GetParcels()
    {
        return Ok(await Context.Parcels.ToListAsync());
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddParcel(AddParcelDto data)
    {
        var parcel = new ParcelEntity
        {
            Street = data.Street,
            HouseNumber = data.HouseNumber,
            City = data.City,
            Country = data.Country,
            Name = data.Name,
            Surname = data.Surname
        };

        await Context.Parcels.AddAsync(parcel);
        await Context.SaveChangesAsync();

        return Ok();
    }

    [HttpPost("deliver")]
    public async Task<IActionResult> Deliver(DeliverParcelDto data)
    {
        var parcel = await Context.Parcels.FirstOrDefaultAsync(x => x.Id == data.Id);

        if (parcel == null)
            return NotFound();

        parcel.Deliver();

        await Context.SaveChangesAsync();

        return Ok();
    }
}