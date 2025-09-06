namespace MP_KT10_2025;

public class CustomerRepository : IRepository<Customer>
{
    private readonly List<Customer> _list = [];

    public void Add(Customer item)
    {
        _list.Add(item);
    }

    public void Delete(Customer item)
    {
        _list.Remove(item);
    }

    public Customer? FindById(int id)
    {
        return _list.Find(x => x.Id == id);
    }

    public IEnumerable<Customer> GetAll()
    {
        return _list;
    }
}
