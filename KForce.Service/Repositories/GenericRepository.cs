using KForce.Service.Data;
using Microsoft.EntityFrameworkCore;

namespace KForce.Service.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly KForceDbContext _dbContext;

    public GenericRepository(KForceDbContext dbContext) => _dbContext = dbContext;

    public IEnumerable<T> GetAll() => _dbContext.Set<T>().ToList();

    public T GetById(int id) => _dbContext.Set<T>().Find(id);

    public int Add(T entity)
    {
        _dbContext.Set<T>().Add(entity);
        return _dbContext.SaveChanges();
    }

    public int Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        return _dbContext.SaveChanges();
    }

    public int Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        return _dbContext.SaveChanges();
    }
}
