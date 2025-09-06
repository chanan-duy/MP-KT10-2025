namespace MP_KT10_2025;

public class ProductRepository : IRepository<Product>
{
    private readonly List<Product> _list = [];

    public void Add(Product item)
    {
        _list.Add(item);
    }

    public void Delete(Product item)
    {
        _list.Remove(item);
    }

    public Product? FindById(int id)
    {
        return _list.Find(x => x.Id == id);
    }

    public IEnumerable<Product> GetAll()
    {
        return _list;
    }
}
