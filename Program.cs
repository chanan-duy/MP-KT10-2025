namespace MP_KT10_2025;

public static class MainLogic
{
    private static void TestCustomerRepository()
    {
        var prodRepo = new CustomerRepository();

        prodRepo.Add(new Customer { Id = 1, Address = "addr1", Name = "name1" });
        prodRepo.Add(new Customer { Id = 2, Address = "addr2", Name = "name2" });
        prodRepo.Add(new Customer { Id = 3, Address = "addr3", Name = "name3" });

        var found = prodRepo.FindById(2);
        if (found != null)
        {
            prodRepo.Delete(found);
        }

        foreach (var customer in prodRepo.GetAll())
        {
            Console.WriteLine($"{customer.Id}\t{customer.Name}\t{customer.Address}");
        }
    }


    private static void TestProductRepository()
    {
        var prodRepo = new ProductRepository();

        prodRepo.Add(new Product { Id = 1, Price = 200.2, Name = "name1" });
        prodRepo.Add(new Product { Id = 2, Price = 202.2, Name = "name2" });
        prodRepo.Add(new Product { Id = 3, Price = 705.2, Name = "name3" });

        var found = prodRepo.FindById(1);
        if (found != null)
        {
            prodRepo.Delete(found);
        }

        foreach (var customer in prodRepo.GetAll())
        {
            Console.WriteLine($"{customer.Id}\t{customer.Name}\t{customer.Price}");
        }
    }

    private static void TestRepositories()
    {
        TestCustomerRepository();
        Console.Write(Environment.NewLine);
        TestProductRepository();
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
