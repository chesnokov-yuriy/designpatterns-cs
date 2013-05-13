using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
        class JapanTime : IObserver
        {
                public JapanTime(Clock subject, Label label)
                {
                        this.subject = subject;
                        this.label = label;
                        this.subject.Attach(this);
                }

                public void Update()
                {
                        this.label.Text = String.Format("Japan {0}", this.subject.Time.AddHours(9).ToLongTimeString());
                }

                public void Dispose()
                {
                        this.subject.Detach(this);
                }

                Clock subject;
                Label label;
        }
}
