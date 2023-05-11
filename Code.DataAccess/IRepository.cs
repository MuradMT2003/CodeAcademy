using Code.Core.Interfaces;
namespace Code.DataAccess;
public interface IRepository<T> where T : class, IEntity, new()
{

    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T? Get(int id);
    List<T> GetAll();
}
