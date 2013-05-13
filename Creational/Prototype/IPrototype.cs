using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype
{
        [Serializable]
        abstract class IPrototype <T>
        {
                public T Clone()
                {
                        return (T)this.MemberwiseClone();
                }

                public T DeepCopy()
                {
                        MemoryStream stream = new MemoryStream( );
                        BinaryFormatter formatter = new BinaryFormatter( );
                        formatter.Serialize(stream, this);
                        stream.Seek(0, SeekOrigin.Begin);
                        T copy = (T)formatter.Deserialize(stream);
                        stream.Close();
                        return copy;
                }
        }
}
