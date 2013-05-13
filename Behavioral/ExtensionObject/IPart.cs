using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionObject
{
        abstract class IPart
        {
                protected void AddExtension(ExtensionType type, IPartExtension partExtension)
                {
                        this.partExtensions[type] = partExtension;
                }

                public IPartExtension GetExtension(ExtensionType type)
                {
                        return this.partExtensions[type];
                }

                public abstract string PartNumber { get; }
                public abstract string Description { get; }

                IDictionary<ExtensionType, IPartExtension> partExtensions = new Dictionary<ExtensionType, IPartExtension>();
        }
}
