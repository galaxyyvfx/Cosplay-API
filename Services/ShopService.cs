using BusinessObjects.DBModels;
using BusinessObjects.DTO;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Services;

public class ShopService
{
    private readonly ShopDAO _dao;

    public ShopService()
    {
        _dao = new ShopDAO();
    }

    public Shop? Get(Guid Id)
    {
        return _dao.Get(Id);
    }

    public List<Shop> GetByShopSearchDTO(ShopSearchDTO searchDTO)
    {
        return _dao.GetByShopSearchDTO(searchDTO);
    }
}
