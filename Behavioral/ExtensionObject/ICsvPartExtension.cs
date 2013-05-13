using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        abstract class ICsvPartExtension : IPartExtension
        {
                public abstract string CsvText { get; }
        }
}
