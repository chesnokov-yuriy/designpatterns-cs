using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
        interface ICarBuilder
        {
                void BuildBody(int durability);
                void BuildEngine(int power);
                void BuildTyres(int size);
                Car GetResult();
        }
}
