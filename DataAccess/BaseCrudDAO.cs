using BusinessObjects.DBModels;

namespace DataAccess;

public class BaseCrudDAO<T, TId> where T : Entity<TId> where TId : IEquatable<TId>
{
    private readonly CosplayHavenDbContext _context;

    public BaseCrudDAO()
    {
        _context = new CosplayHavenDbContext();
    }

    public T? Get(TId Id)
    {
        T? entity = _context.Set<T>().FirstOrDefault(e => e.Id.Equals(Id));

        return entity;
    }

    public T Create(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();

        return entity;
    }

    public T Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();

        return entity;
    }

    public int Delete(TId entityId)
    {
        var existingEntity = _context.Set<T>().FirstOrDefault(e => e.Id.Equals(entityId));

        if (existingEntity != null)
        {
            _context.Remove(existingEntity);
            _context.SaveChanges();
        }
        return 0;
    }
}
