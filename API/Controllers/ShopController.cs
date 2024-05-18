using BusinessObjects.DBModels;
using BusinessObjects.DTO;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShopController : ControllerBase
{
    private readonly ShopService shopService;

    public ShopController()
    {
        shopService = new ShopService();
    }

    [HttpGet("{id}")]
    public ActionResult<Shop> Get(Guid id)
    {
        try
        {
            var shop = shopService.Get(id);
            return Ok(shop);
        } 
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult<List<Shop>> GetByShopSearchDTO([FromQuery]ShopSearchDTO shopSearchDTO)
    {
        try
        {
            var shopList = shopService.GetByShopSearchDTO(shopSearchDTO);
            return Ok(shopList);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
