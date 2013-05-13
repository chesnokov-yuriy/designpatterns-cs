using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        class TxtAssemblyExtension : ITxtPartExtension
        {
                public TxtAssemblyExtension(Assembly assembly)
                {
                        this.assembly = assembly;
                }

                public override string PlainText 
                {
                        get
                        {
                                StringBuilder sb = new StringBuilder();
                                sb.AppendFormat("Assembly: {0} {1}\r\n", this.assembly.PartNumber, this.assembly.Description);
                                foreach (IPart part in this.assembly.Parts)
                                {
                                        TxtPiecePartExtension ppe = part.GetExtension(ExtensionType.Txt) as TxtPiecePartExtension;
                                        sb.AppendFormat("{0}", ppe.PlainText);
                                }
                                return sb.ToString();
                        }
                }

                Assembly assembly;
        }
}
