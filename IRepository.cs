namespace MP_KT10_2025;

public interface IRepository<T> where T : IEntity
{
    public void Add(T item);
    public void Delete(T item);
    public T? FindById(int id);
    public IEnumerable<T> GetAll();
}
