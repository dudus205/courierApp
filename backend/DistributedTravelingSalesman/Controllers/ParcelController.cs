using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DistributedTravelingSalesman.Controllers;

[ApiController]
public class ParcelController : ControllerBase
{
    [HttpGet]
    public Task<IActionResult> GetParcels()
    {
        
    }

    [HttpPost]
    public Task<IActionResult> AddParcel(AddParcelDto data)
    {
        
    }

    [HttpPost]
    public Task<IActionResult> Deliver(DeliverParcelDto data)
    {
        
    }
}

public class AddParcelDto
{
}

public class DeliverParcelDto
{
}