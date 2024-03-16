using Xurmo.Domain.Commons;
using Xurmo.Data.IRepastories;
using Xurmo.Data.AddDbContext;
using Microsoft.EntityFrameworkCore;

namespace Xurmo.Data.Repastories;

public class Repastory<TEntity> : IRepostory<TEntity> where TEntity : Auditable
{
    private readonly XurmoDbContext context;
    private readonly DbSet<TEntity> entities;
    public Repastory(XurmoDbContext contexts)
    {
        this.context = contexts;
        this.entities = context.Set<TEntity>();
    }

    public Task<TEntity> InsertAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> GetAllAsEnumerable()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetAllAsQueryable()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> SelectById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
