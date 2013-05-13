using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
        [Serializable]
        class Originator
        {
                public void DoWork(string text)
                {
                        this.state.Add(text);
                }

                public void PrintMe()
                {
                        foreach (string text in this.state)
                                Console.WriteLine(text);
                }                

                public Memento CreateMemento()
                {
                        Memento memento = new Memento();
                        memento.Save(this.state);
                        return memento;
                }

                public void SetMemento(Memento memento)
                {
                        this.state = (List<string>)memento.Restore();
                }

                List<string> state = new List<string>();
        }
}
