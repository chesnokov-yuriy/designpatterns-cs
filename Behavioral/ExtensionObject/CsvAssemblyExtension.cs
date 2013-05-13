using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        class CsvAssemblyExtension : ICsvPartExtension
        {
                public CsvAssemblyExtension(Assembly assembly)
                {
                        this.assembly = assembly;
                }

                public override string CsvText 
                {
                        get
                        {
                                StringBuilder sb = new StringBuilder();
                                sb.AppendFormat("Assembly,{0},{1}\r\n", this.assembly.PartNumber, this.assembly.Description);
                                foreach (IPart part in this.assembly.Parts)
                                {
                                        CsvPiecePartExtension ppe = part.GetExtension(ExtensionType.Csv) as CsvPiecePartExtension;
                                        sb.AppendFormat("{0}", ppe.CsvText);
                                }
                                return sb.ToString();
                        }
                }

                Assembly assembly;
        }
}
