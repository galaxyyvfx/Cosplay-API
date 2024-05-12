using BusinessObjects.DBModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShopController : ControllerBase
{
    private readonly BaseCrudService<Shop, Guid> _service;

    public ShopController()
    {
        _service = new BaseCrudService<Shop, Guid>();
    }

    [HttpGet("{id}")]
    public ActionResult<Shop> Get(Guid id)
    {
        try
        {
            var record = _service.Get(id);
            return Ok(record);
        } 
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
