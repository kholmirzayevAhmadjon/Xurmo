using Xurmo.Domain.Commons;

namespace Xurmo.Data.IRepastories;

public interface IRepostory<TEntity> where TEntity : Auditable
{
    Task<TEntity> InsertAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task<TEntity> DeleteAsync(TEntity entity);

    Task<TEntity> SelectById(long id);

    IQueryable<TEntity> GetAllAsQueryable();

    IEnumerable<TEntity> GetAllAsEnumerable();
}
