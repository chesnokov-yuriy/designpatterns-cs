using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
        class LocalTime : IObserver
        {
                public LocalTime(ISubject subject, Label label)
                {
                        this.subject = subject;
                        this.label = label;
                        this.subject.Attach(this);
                }

                public void Update(Object hint)
                {
                        DateTime time = (DateTime)hint;
                        this.label.Text = String.Format("local {0}", time.ToLocalTime().ToLongTimeString());
                }

                public void Dispose()
                {
                        this.subject.Detach(this);
                }

                ISubject subject;
                Label label;
        }
}
