using BusinessObjects.DBModels;
using BusinessObjects.DTO;
using System.Linq;

namespace DataAccess;

public class ShopDAO
{
    private readonly CosplayHavenDbContext _context;

    public ShopDAO()
    {
        _context = new CosplayHavenDbContext();
    }

    public Shop? Get(Guid Id)
    {
        Shop? entity = _context.Shops.FirstOrDefault(e => e.Id.Equals(Id));
        return entity;
    }

    public List<Shop> GetByShopSearchDTO(ShopSearchDTO searchDTO) 
    {
        var search = !string.IsNullOrEmpty(searchDTO.Search) ? searchDTO.Search : string.Empty;

        List<Shop> shops = _context.Shops
            .Where(shop => shop.Name.Contains(search))
            .ToList();

        return shops;
    }
}
