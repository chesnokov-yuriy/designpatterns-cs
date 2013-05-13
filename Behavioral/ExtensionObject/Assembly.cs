using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        class Assembly : IPart
        {
                public Assembly(string partNumber, string description)
                {
                        this.partNumber = partNumber;
                        this.description = description;

                        AddExtension(ExtensionType.Txt, new TxtAssemblyExtension(this));
                        AddExtension(ExtensionType.Csv, new CsvAssemblyExtension(this));
                }

                public override string PartNumber
                {
                        get { return partNumber; }
                }

                public override string Description
                {
                        get { return description; }
                }

                public void Add(IPart part)
                {
                        this.parts.Add(part);
                }

                public IEnumerable<IPart> Parts
                {
                        get { return this.parts; }
                }

                string partNumber;
                string description;
                IList<IPart> parts = new List<IPart>();
        }
}
