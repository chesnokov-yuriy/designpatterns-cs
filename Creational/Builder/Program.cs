using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
        class Program
        {
                static void Main(string[] args)
                {
                        ICarBuilder raceCarBuilder = new RaceCarBuilder();
                        CarFactory.BuildRaceCar(raceCarBuilder);
                        Car car = raceCarBuilder.GetResult();
                        Console.WriteLine("race car: body({0}),engine({1}),tyres({2})", car.BodyDurability, car.EnginePower, car.TyreSize);
                }
        }
}
