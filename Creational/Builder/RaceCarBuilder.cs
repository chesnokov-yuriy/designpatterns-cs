using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
        class RaceCarBuilder : ICarBuilder
        {
                public void BuildBody(int durability)
                {
                        this.car.BodyDurability = durability;
                }

                public void BuildEngine(int power)
                {
                        this.car.EnginePower = power;
                }

                public void BuildTyres(int size)
                {
                        this.car.TyreSize = size;
                }

                public Car GetResult()
                {
                        return this.car;
                }

                Car car = new Car();
        }
}
