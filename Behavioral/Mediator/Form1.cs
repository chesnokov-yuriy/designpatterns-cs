using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mediator
{
        public partial class Form1 : Form
        {
                public Form1()
                {
                        InitializeComponent();

                        QuickEntryMediator mediator = new QuickEntryMediator();
                        EntryField entryField = new EntryField(this.entryTextBox, mediator);
                        Vocabluary vocabluary = new Vocabluary(this.vocabluaryListBox, mediator);
                        mediator.SetColleagues(entryField, vocabluary);                        
                }
        }
}
