namespace MP_KT10_2025;

public static class MainLogic
{
    private static void TestCustomerRepository()
    {
        var customerRepo = new CustomerRepository();

        customerRepo.Add(new Customer { Id = 1, Address = "addr1", Name = "name1" });
        customerRepo.Add(new Customer { Id = 2, Address = "addr2", Name = "name2" });
        customerRepo.Add(new Customer { Id = 3, Address = "addr3", Name = "name3" });

        var found = customerRepo.FindById(2);
        if (found != null)
        {
            customerRepo.Delete(found);
        }

        foreach (var customer in customerRepo.GetAll())
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

        foreach (var product in prodRepo.GetAll())
        {
            Console.WriteLine($"{product.Id}\t{product.Name}\t{product.Price}");
        }
    }

    private static void TestRepositories()
    {
        TestCustomerRepository();
        Console.Write(Environment.NewLine);
        TestProductRepository();
    }

    private static void TestPoint()
    {
        var point1 = new Point(12, 34);
        Console.WriteLine(point1);
        var point2 = point1.Clone();
        Console.WriteLine(point2);
        Console.WriteLine($"point1 == point2 (by ref): {point1 == point2}");
    }

    private static void TestRectangle()
    {
        var rectangle1 = new Rectangle(12, 34);
        Console.WriteLine(rectangle1);
        var rectangle2 = rectangle1.Clone();
        Console.WriteLine(rectangle2);
        Console.WriteLine($"rectangle1 == rectangle2 (by ref): {rectangle1 == rectangle2}");
    }

    private static void TestClonable()
    {
        TestPoint();
        Console.Write(Environment.NewLine);
        TestRectangle();
    }

    private static void TestRnc()
    {
        var comparerRational = new RationalNumberComparer();

        {
            var r1 = new RationalNumber(2, 3);
            var r2 = new RationalNumber(5, 7);

            Console.WriteLine(
                $"{r1.Numerator}/{r1.Denominator} {comparerRational.CompareToString(r1, r2)} {r2.Numerator}/{r2.Denominator}");
        }
        {
            var r1 = new RationalNumber(1, 2);
            var r2 = new RationalNumber(2, 4);

            Console.WriteLine(
                $"{r1.Numerator}/{r1.Denominator} {comparerRational.CompareToString(r1, r2)} {r2.Numerator}/{r2.Denominator}");
        }

        {
            var r1 = new RationalNumber(2334, 15634);
            var r2 = new RationalNumber(1, 1777777);

            Console.WriteLine(
                $"{r1.Numerator}/{r1.Denominator} {comparerRational.CompareToString(r1, r2)} {r2.Numerator}/{r2.Denominator}");
        }
    }

    private static void TestCnc()
    {
        var comparer = new ComplexNumberComparer();

        var num1 = new ComplexNumber(3, 4);
        var num2 = new ComplexNumber(4, 3);

        Console.WriteLine($"{num1.Real} + i({num1.Imaginary}) {comparer.CompareToString(num1, num2)} {num2.Real} + i({num2.Imaginary})");
    }

    private static void TestComparer()
    {
        TestRnc();
        Console.Write(Environment.NewLine);
        TestCnc();
    }

    public static void RunLogic()
    {
        TestRepositories();
        Console.Write(Environment.NewLine);
        TestClonable();
        Console.Write(Environment.NewLine);
        TestComparer();
    }
}

public static class Program
{
    public static void Main(string[] _)
    {
        MainLogic.RunLogic();
    }
}
