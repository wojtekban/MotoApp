﻿namespace MotoApp.DataProviders;

public interface ICarsProvider
{
    // select85
    List<string> GetUniqueCarColors();
    decimal GetMinimumPriceOfAllCars();
    List<Car> GetSpecificColumns();
    string AnonymousClass();


    // order by
    List<Car> OrderByName();
    List<Car> OrderByNameDescending();
    List<Car> OrderByColorAndName();
    List<Car> OrderByColorAndNameDesc();

    //where
    List<Car> WhereStartsWith(string color);
    List<Car> WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost);
    List<Car> WhereColorIs(string color);

    // first, last, single
    Car FirstByColor(string color);
    Car? FirstOrDefaultByColor(string color);
    Car FirstOrDefaultByColorWithDefault(string color);
    Car LastByColor(string color);
    Car SingleById(int id);
    Car? SingleOrDefaultById(int id);

    // Take
    List<Car> TakeCars(int howMany);
    List<Car> TakeCars(Range range);
    List<Car> TakeCarsWhileNameStartsWith(string prefix);

    // Skip
    List <Car> SkipCars(int howMany);
    List <Car> SkipCarsWhileNameStartsWith(string prefix);

    //Distinct
    List<string> DistinctAllColors();
    List<Car> DistinctByColors();

    // Chunk
    List<Car[]> ChunkCars(int size);


}

