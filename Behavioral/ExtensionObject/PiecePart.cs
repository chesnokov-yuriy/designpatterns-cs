using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        class PiecePart : IPart
        {
                public PiecePart(string partNumber, string description, double cost)
                {
                        this.partNumber = partNumber;
                        this.description = description;
                        this.cost = cost;

                        AddExtension(ExtensionType.Txt, new TxtPiecePartExtension(this));
                        AddExtension(ExtensionType.Csv, new CsvPiecePartExtension(this));
                }

                public override string PartNumber
                {
                        get { return this.partNumber; }
                }

                public override string Description
                {
                        get { return this.description; }
                }

                public double Cost
                {
                        get { return this.cost; }
                }

                private string partNumber;
                private string description;
                private double cost;
        }
}
