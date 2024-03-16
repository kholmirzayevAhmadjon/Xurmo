using Xurmo.Domain.Commons;

namespace Xurmo.Data.IRepastories;

public interface IRepostory<TEntity> where TEntity : Auditable
{
    Task<TEntity> InsertAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task<TEntity> DeleteAsync(TEntity entity);

    Task<TEntity> SelectByIddAsync(long id);

    IQueryable<TEntity> SelectAllAsQueryable();

    IEnumerable<TEntity> SelectAllAsEnumerable();

    Task SavedAsync();
}
