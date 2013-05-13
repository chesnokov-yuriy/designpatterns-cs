using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
        class JapanTime : IObserver
        {
                public JapanTime(ISubject subject, Label label)
                {
                        this.subject = subject;
                        this.label = label;
                        this.subject.Attach(this);
                }

                public void Update(Object hint)
                {
                        DateTime time = (DateTime)hint;
                        this.label.Text = String.Format("Japan {0}", time.AddHours(9).ToLongTimeString());
                }

                public void Dispose()
                {
                        this.subject.Detach(this);
                }

                ISubject subject;
                Label label;
        }
}
