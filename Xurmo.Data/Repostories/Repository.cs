using Xurmo.Domain.Commons;
using Xurmo.Data.IRepostories;
using Xurmo.Data.AddDbContext;
using Microsoft.EntityFrameworkCore;

namespace Xurmo.Data.Repastories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    private readonly XurmoDbContext context;
    private readonly DbSet<TEntity> entities;
    public Repository(XurmoDbContext contexts)
    {
        this.context = contexts;
        this.entities = context.Set<TEntity>();
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        return (await entities.AddAsync(entity)).Entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        return await Task.FromResult(entity);
    }

    public IEnumerable<TEntity> SelectAllAsEnumerable()
    {
        return entities.AsEnumerable();
    }

    public IQueryable<TEntity> SelectAllAsQueryable()
    {
        return entities.AsQueryable();
    }


    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        entities.Entry(entity).State = EntityState.Modified;
        return await Task.FromResult(entity);
    }

    public async Task SavedAsync()
    {
        await context.SaveChangesAsync();
    }

    public async Task<TEntity> SelectByIddAsync(long id)
    {
        return await entities.FirstOrDefaultAsync(entity => entity.Id == id && !entity.IsDeleted);
    }
}
