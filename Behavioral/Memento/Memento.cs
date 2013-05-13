using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Memento
{
        class Memento
        {
                public void Save(object state)
                {
                        this.stream = new MemoryStream();
                        this.formatter = new BinaryFormatter();
                        this.formatter.Serialize(stream, state);                        
                }

                public object Restore()
                {
                        this.stream.Position = 0;
                        object state = formatter.Deserialize(stream);
                        this.stream.Close();
                        return state;
                }

                MemoryStream stream = null;
                BinaryFormatter formatter = null;
        }
}
