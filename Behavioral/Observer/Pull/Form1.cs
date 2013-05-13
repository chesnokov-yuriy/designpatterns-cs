using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{        
        public partial class Form1 : Form
        {                
                public Form1()
                {                                                
                        InitializeComponent();                        
                }

                private void runButton_Click(object sender, EventArgs e)
                {
                        this.clock = new Clock();
                        this.utcTime = new UTCTime(clock, this.utcLabel);
                        this.localTime = new LocalTime(clock, this.localLabel);
                        this.japanTime = new JapanTime(clock, this.japanLabel);

                        this.runButton.Enabled = false;
                        this.stopButton.Enabled = true;
                }

                private void stopButton_Click(object sender, EventArgs e)
                {
                        this.localTime.Dispose();
                        this.clock.Dispose();

                        this.runButton.Enabled = true;
                        this.stopButton.Enabled = false;
                }

                Clock clock = null;
                IObserver utcTime = null;
                IObserver localTime = null;                
                IObserver japanTime = null;
        }
}
