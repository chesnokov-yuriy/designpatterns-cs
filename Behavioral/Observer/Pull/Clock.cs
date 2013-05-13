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

                public DateTime Time { get; private set; }

                public void Attach(IObserver observer)
                {
                        this.observers.Add(observer);
                }

                public void Detach(IObserver observer)
                {
                        this.observers.Remove(observer);
                }

                public void Notify()
                {
                        foreach (IObserver observer in this.observers)
                                observer.Update();
                }                

                void TimerTick(object sender, EventArgs e)
                {
                        Time = DateTime.UtcNow;
                        Notify();
                }

                public void Dispose()
                {
                        this.timer.Stop();
                }

                Timer timer = new Timer();
                IList<IObserver> observers = new List<IObserver>();
        }
}
