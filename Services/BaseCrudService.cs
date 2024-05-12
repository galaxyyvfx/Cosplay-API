using BusinessObjects.DBModels;
using DataAccess;

namespace Services;

public class BaseCrudService<T, TId> where T : Entity<TId> where TId : IEquatable<TId>
{
    private readonly BaseCrudDAO<T, TId> _dao;

    public BaseCrudService()
    {
        _dao = new BaseCrudDAO<T, TId>();
    }

    public T? Get(TId Id)
    {
        return _dao.Get(Id);
    }

    public T Create(T entity)
    {
        return _dao.Create(entity);
    }

    public T Update(T entity)
    {
        return _dao.Update(entity);
    }

    public int Delete(TId entityId)
    {
        return _dao.Delete(entityId);
    }
}
