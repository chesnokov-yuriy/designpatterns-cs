using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
        class QuickEntryMediator : IMediator
        {                
                public void SetColleagues(EntryField entryField, Vocabluary vocabluary)
                {
                        this.entryField = entryField;
                        this.vocabluary = vocabluary;
                }

                public void ColleagueChanged(IColleague colleague)
                {
                        if (colleague is EntryField)
                        {
                                string prefix = this.entryField.GetText();
                                if (!String.IsNullOrEmpty(prefix))
                                        this.vocabluary.SelectWord(prefix);
                        }                        
                }

                EntryField entryField;
                Vocabluary vocabluary;
        }
}
