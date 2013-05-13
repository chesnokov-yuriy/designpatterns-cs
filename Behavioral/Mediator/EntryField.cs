using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mediator
{
        class EntryField : IColleague
        {
                public EntryField(TextBox textBox, IMediator mediator)
                        : base(mediator)
                {
                        this.textBox = textBox;
                        this.textBox.TextChanged += new EventHandler(textBox_TextChanged);
                }

                public string GetText()
                {
                        return this.textBox.Text;
                }

                public void SetText(string text)
                {
                        this.textBox.Text = text;
                }

                void textBox_TextChanged(object sender, EventArgs e)
                {                        
                        Changed();
                }

                TextBox textBox;
        }
}
