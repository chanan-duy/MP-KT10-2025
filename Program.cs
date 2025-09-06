namespace MP_KT10_2025;

public static class MainLogic
{
    private static void TestRepositories()
    {
        var cusRepo = new CustomerRepository();

        cusRepo.Add(new Customer { Id = 1, Address = "addr1", Name = "name1" });
        cusRepo.Add(new Customer { Id = 2, Address = "addr2", Name = "name2" });
        cusRepo.Add(new Customer { Id = 3, Address = "addr3", Name = "name3" });

        var found = cusRepo.FindById(2);
        if (found != null)
        {
            cusRepo.Delete(found);
        }

        foreach (var customer in cusRepo.GetAll())
        {
            Console.WriteLine($"{customer.Id}\t{customer.Name}\t{customer.Address}");
        }

        var prodRepo = new ProductRepository();
    }

    public static void RunLogic()
    {
        TestRepositories();
        Console.Write(Environment.NewLine);
    }
}

public static class Program
{
    public static void Main(string[] _)
    {
        MainLogic.RunLogic();
    }
}
