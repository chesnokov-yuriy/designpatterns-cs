using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mediator
{
        class Vocabluary : IColleague
        {
                public Vocabluary(ListBox listBox, IMediator mediator)
                        : base(mediator)
                {
                        this.listBox = listBox;
                        this.listBox.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
                }

                public string GetSelectedWord()
                {
                        if (this.listBox.SelectedItem != null)
                                return this.listBox.SelectedItem.ToString();
                        else
                                return String.Empty;
                }

                public void SelectWord(string prefix)
                {
                        for (int i = 0; i < this.listBox.Items.Count; i++)
                        {
                                if (this.listBox.Items[i].ToString().StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase))
                                {
                                        this.listBox.SelectedIndex = i;
                                        return;
                                }
                        }
                        this.listBox.SelectedIndex = -1;
                }

                void listBox_SelectedIndexChanged(object sender, EventArgs e)
                {
                        Changed();
                }

                ListBox listBox;
        }
}
