using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
        class Clock : ISubject
        {
                public Clock()
                {
                        this.timer.Interval = 1000;
                        this.timer.Tick += new EventHandler(TimerTick);
                        this.timer.Start();                        
                }                

                public void Attach(IObserver observer)
                {
                        this.observers.Add(observer);
                }

                public void Detach(IObserver observer)
                {
                        this.observers.Remove(observer);
                }

                public void Notify(Object hint)
                {
                        foreach (IObserver observer in this.observers)
                                observer.Update(hint);
                }                

                void TimerTick(object sender, EventArgs e)
                {                        
                        Notify(DateTime.UtcNow);
                }

                public void Dispose()
                {
                        this.timer.Stop();
                }

                Timer timer = new Timer();
                IList<IObserver> observers = new List<IObserver>();
        }
}
