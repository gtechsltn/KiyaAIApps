using Core_API.Models;

namespace Core_API.Services
{
    /// <summary>
    /// TEntity: ANy type derived from ENtityBAse
    /// THe 'in' is always an input parameter
    /// TPk will be a Primary Key
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IDataService<TEntity, in TPk> where TEntity : EntityBase
    {
        Task<ResponseObject<TEntity>> GetAsync();
        Task<ResponseObject<TEntity>> GetAsync(TPk id);
        Task<ResponseObject<TEntity>> CreateAsync(TEntity entity);
        Task<ResponseObject<TEntity>> UpdateAsync(TPk id, TEntity entity);
        Task<ResponseObject<TEntity>> DeleteAsync(TPk id);
    }
}
