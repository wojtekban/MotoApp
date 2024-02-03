﻿using MotoApp.Components.CsvReader.Extensions;
using MotoApp.Components.CsvReader.Models;
namespace MotoApp.Components.CsvReader;

public class CsvReader : ICsvReader
{
    public List<TCar> ProcessCars(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return new List<TCar>();
        }

        var cars = File.ReadAllLines(filePath)
            .Skip(1)
            .Where(x => x.Length > 1)
            .ToCar();
        return cars.ToList();
    }
    public List<Manufacturer> ProcessManufacturers(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return new List<Manufacturer>();
        }

        var manufacturers = File.ReadAllLines(filePath)
            .Where(x => x.Length > 1)
            .Select(x =>
            {
                var columns = x.Split(',');
                return new Manufacturer()
                {
                    Name = columns[0],
                    Country = columns[1],
                    Year = int.Parse(columns[2])
                };
            });
        return manufacturers.ToList();
    }
}
