using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        class TxtPiecePartExtension : ITxtPartExtension
        {
                public TxtPiecePartExtension(PiecePart piecePart)
                {
                        this.piecePart = piecePart;
                }

                public override string PlainText 
                {
                        get
                        {
                                StringBuilder sb = new StringBuilder();
                                sb.AppendFormat("PiecePart: {0} {1} ({2})\r\n", this.piecePart.PartNumber, this.piecePart.Description, this.piecePart.Cost);
                                return sb.ToString();
                        }
                }

                PiecePart piecePart;
        }
}
