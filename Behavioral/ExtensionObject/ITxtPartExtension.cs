using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        abstract class ITxtPartExtension : IPartExtension
        {
                public abstract string PlainText { get; }
        }
}
