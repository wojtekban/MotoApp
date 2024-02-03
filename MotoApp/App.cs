using MotoApp.Components.CsvReader;

namespace MotoApp;

public class App : IApp
{
    private readonly ICsvReader _csvReader;
    public App(ICsvReader csvReader)
    {
            _csvReader = csvReader;
    }

    public void Run()
    {
        var cars = _csvReader.ProcessCars("Resources\\Files\\fuel.csv");
        var manufacturers = _csvReader.ProcessManufacturers("Resources\\Files\\manufacturers.csv");
    }
}
    //private readonly IRepository<Employee> _employeesRepository;
    //private readonly IRepository<Car> _carsRepository;
    //private readonly ICarsProvider _carsProvider;

    //public ICarsProvider carsProvider { get; }

    //public App(
    //    IRepository<Employee> employeesRepository, 
    //    IRepository<Car> carsRepository,
    //    ICarsProvider carsProvider)
    //{
    //    _employeesRepository = employeesRepository;
    //    _carsRepository = carsRepository;
    //    _carsProvider = carsProvider;
    //}
    //public void Run()
    //{
    //Console.WriteLine("I`m here in Run() method");

    //    //adding
    //    var employees = new[]
    //    {
    //        new Employee { FirstName = "Adam"},
    //        new Employee { FirstName = "Piotr"},
    //        new Employee { FirstName = "Zuzanna"},
    //    };

    //    foreach (var employee in employees)
    //    {
    //        _employeesRepository.Add(employee);
    //    }

    //    _employeesRepository.Save();

    //    //reading
    //    var items = _employeesRepository.GetAll();
    //    foreach (var item in items)
    //    {
    //        Console.WriteLine(item);
    //    }

    //    // cars
    //    var cars = GenerateSampleCars();
    //    foreach (var item in cars)
    //    {
    //        _carsRepository.Add(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("GetUniqueCarCorols");
    //    foreach (var item in _carsProvider.OrderByColorAndName())
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("GetMinimumPriceOfAllCars");
    //    Console.WriteLine(_carsProvider.GetMinimumPriceOfAllCars());

        
    //    Console.WriteLine();
    //    Console.WriteLine("OrderByName");
    //    foreach (var item in _carsProvider.OrderByName())
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("OrderByNameDescending");
    //    foreach (var item in _carsProvider.OrderByNameDescending())
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("OrderByColorAndName");
    //    foreach (var item in _carsProvider.OrderByColorAndName())
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("OrderByColorAndNameDesc");
    //    foreach (var item in _carsProvider.OrderByColorAndNameDesc())
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("WhereStartsWith A");
    //    foreach (var item in _carsProvider.WhereStartsWith("A"))
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("WhereStartsWithAndCostIsGreaterThan A / 1000");
    //    foreach (var item in _carsProvider.WhereStartsWithAndCostIsGreaterThan("A", 1000))
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("WhereColorIs Red");
    //    foreach (var item in _carsProvider.WhereColorIs("Red"))
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("FirstByColor");
    //    Console.WriteLine(_carsProvider.FirstOrDefaultByColor("Red"));

    //    Console.WriteLine();
    //    Console.WriteLine("FirstOrDefoultByColor");
    //    Console.WriteLine(_carsProvider.FirstOrDefaultByColor("Red"));

    //    Console.WriteLine();
    //    Console.WriteLine("FirstOrDefaultByColorWithDefault");
    //    Console.WriteLine(_carsProvider.FirstOrDefaultByColorWithDefault("Red"));

    //    Console.WriteLine();
    //    Console.WriteLine("LastByColor");
    //    Console.WriteLine(_carsProvider.LastByColor("Red"));

    //    Console.WriteLine();
    //    Console.WriteLine("SingleById");
    //    Console.WriteLine(_carsProvider.SingleById(10));


    //    Console.WriteLine();
    //    Console.WriteLine("SingleOrDefaultById");
    //    Console.WriteLine(_carsProvider.SingleOrDefaultById(10));

    //    Console.WriteLine();
    //    Console.WriteLine("TakeCars");
    //    foreach (var car in _carsProvider.TakeCars(10))
    //    {
    //        Console.WriteLine(car);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("TakeCarsRange");
    //    foreach (var car in _carsProvider.TakeCars(2..5))
    //    {
    //        Console.WriteLine(car);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("TakeCarsWhileNameStartsWith S");
    //    foreach (var car in _carsProvider.TakeCarsWhileNameStartsWith("S"))
    //    {
    //        Console.WriteLine(car);
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine("SkipCars");
    //    foreach (var item in _carsProvider.SkipCars(10))
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("SkipCarsWhileNameStartsWith C");
    //    foreach (var item in _carsProvider.SkipCarsWhileNameStartsWith("C"))
    //    {
    //        Console.WriteLine(item);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("DistinctAllColors");
    //    foreach (var car in _carsProvider.DistinctAllColors())
    //    {
    //        Console.WriteLine(car);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("DistinctByColors");
    //    foreach (var car in _carsProvider.DistinctByColors())
    //    {
    //        Console.WriteLine(car);
    //    }

    //    Console.WriteLine();
    //    Console.WriteLine("ChunkCars");
    //    foreach (var item in _carsProvider.ChunkCars(3))
    //    {
    //        Console.WriteLine($"Chunnk:");
    //        foreach (var i in item)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        Console.WriteLine("###");
    //    }
   // }

    //public static List<Car> GenerateSampleCars()
    //{
    //    return new List<Car>
    //    {
    //        new Car
    //        {
    //            Id =680,
    //            Name = "Car 1",
    //            Color = "Black",
    //            StandardCost = 1059.31M,
    //            ListPrice = 1431.50M,
    //            Type = "58",
    //        },
    //        new Car
    //        {
    //            Id =706,
    //            Name = "Car 2",
    //            Color = "Red",
    //            StandardCost = 1059.31M,
    //            ListPrice = 1431.50M,
    //            Type = "58",
    //        },
    //        new Car
    //        {
    //            Id =707,
    //            Name = "Car 3",
    //            Color = "Red",
    //            StandardCost = 13.08M,
    //            ListPrice = 34.99M,
    //            Type = "null",
    //        },
    //        new Car
    //        {
    //            Id =708,
    //            Name = "Car 4",
    //            Color = "Blue",
    //            StandardCost = 15.08M,
    //            ListPrice = 24.99M,
    //            Type = "24",
    //        },
    //        new Car
    //        {
    //            Id =709,
    //            Name = "Car 5",
    //            Color = "Yellow",
    //            StandardCost = 11.08M,
    //            ListPrice = 35.99M,
    //            Type = "58",
    //        },
    //        new Car
    //        {
    //            Id =710,
    //            Name = "Car 6",
    //            Color = "Green",
    //            StandardCost = 16.08M,
    //            ListPrice = 27.99M,
    //            Type = "30",
    //        },
    //        new Car
    //        {
    //            Id =711,
    //            Name = "Car 7",
    //            Color = "Red",
    //            StandardCost = 43.08M,
    //            ListPrice = 14.99M,
    //            Type = "30",
    //        },
    //        new Car
    //        {
    //            Id =712,
    //            Name = "Car 8",
    //            Color = "Bleck",
    //            StandardCost = 16.08M,
    //            ListPrice = 22.99M,
    //            Type = "null",
    //        },
    //        new Car
    //        {
    //            Id =713,
    //            Name = "Car 9",
    //            Color = "Yellow",
    //            StandardCost = 12.08M,
    //            ListPrice = 44.99M,
    //            Type = "58",
    //        },
    //        new Car
    //        {
    //            Id =714,
    //            Name = "Car 10",
    //            Color = "Blue",
    //            StandardCost = 11.08M,
    //            ListPrice = 35.99M,
    //            Type = "32",
    //        },
    //        new Car
    //        {
    //            Id =715,
    //            Name = "Car 11",
    //            Color = "Orange",
    //            StandardCost = 14.08M,
    //            ListPrice = 37.99M,
    //            Type = "52",
    //        },
    //        new Car
    //        {
    //            Id =716,
    //            Name = "Car 12",
    //            Color = "Red",
    //            StandardCost = 9.08M,
    //            ListPrice = 20.99M,
    //            Type = "45",
    //        },
    //        new Car
    //        {
    //            Id =717,
    //            Name = "Car 3",
    //            Color = "Bleck",
    //            StandardCost = 10.08M,
    //            ListPrice = 30.99M,
    //            Type = "null",
    //        }
    //    };
    //}
//}

