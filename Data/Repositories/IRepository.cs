namespace Data.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity? GetById(int id);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

    void Add(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);

    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);

    void Update(TEntity entity);
    void UpdateRange(IEnumerable<TEntity> entities);
}
