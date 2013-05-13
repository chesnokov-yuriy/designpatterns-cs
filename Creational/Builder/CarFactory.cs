using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
        static class CarFactory
        {
                static public void BuildRaceCar(ICarBuilder builder)
                {
                        builder.BuildBody(10);
                        builder.BuildEngine(1000);
                        builder.BuildTyres(100);
                }

                static public void BuildEconomyCar(ICarBuilder builder)
                {
                        builder.BuildBody(10);
                        builder.BuildEngine(50);
                        builder.BuildTyres(10);
                }

                static public void BuildHeavyCar(ICarBuilder builder)
                {
                        builder.BuildBody(100);
                        builder.BuildEngine(2000);
                        builder.BuildTyres(200);
                }
        }
}
