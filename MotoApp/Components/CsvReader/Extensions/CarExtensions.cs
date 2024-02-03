using System.Globalization;
using MotoApp.Components.CsvReader.Models;


namespace MotoApp.Components.CsvReader.Extensions;

public static class CarExtensions
{
    public static IEnumerable<TCar> ToCar(this IEnumerable<string> source)
    {
        foreach (var line in source)
        {
            var columns = line.Split(',');
            yield return new TCar
            {
                Year = int.Parse(columns[0]),
                Manufacturer = columns[1],
                Name = columns[2],
                Displacement = double.Parse(columns[3], CultureInfo.InvariantCulture),
                Cylinders = int.Parse(columns[4]),
                City = int.Parse(columns[5]),
                Highway = int.Parse(columns[6]),
                Combined = int.Parse(columns[7])
            };
        }
    }
}
