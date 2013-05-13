using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
        class UTCTime : IObserver
        {
                public UTCTime(Clock subject, Label label)
                {
                        this.subject = subject;
                        this.label = label;
                        this.subject.Attach(this);
                }

                public void Update()
                {
                        this.label.Text = String.Format("UTC {0}", this.subject.Time.ToLongTimeString());
                }

                public void Dispose()
                {
                        this.subject.Detach(this);
                }

                Clock subject;
                Label label;
        }
}
