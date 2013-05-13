using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        class Program
        {
                static void Main(string[] args)
                {
                        PiecePart p1 = new PiecePart("997624", "Rail", 3.20);
                        PiecePart p2 = new PiecePart("7734", "Truck", 19.2);
                        Assembly a = new Assembly("5879", "Station");

                        a.Add(p1);
                        a.Add(p2);

                        Console.WriteLine("Text extension:");
                        TxtPiecePartExtension ppte1 = p1.GetExtension(ExtensionType.Txt) as TxtPiecePartExtension;
                        Console.WriteLine("{0}", ppte1.PlainText);
                        TxtAssemblyExtension ate = a.GetExtension(ExtensionType.Txt) as TxtAssemblyExtension;
                        Console.WriteLine("{0}", ate.PlainText);

                        Console.WriteLine("CSV extension:");
                        CsvPiecePartExtension ppce1 = p1.GetExtension(ExtensionType.Csv) as CsvPiecePartExtension;
                        Console.WriteLine("{0}", ppce1.CsvText);
                        CsvAssemblyExtension ace = a.GetExtension(ExtensionType.Csv) as CsvAssemblyExtension;
                        Console.WriteLine("{0}", ace.CsvText);
                }                
        }
}
