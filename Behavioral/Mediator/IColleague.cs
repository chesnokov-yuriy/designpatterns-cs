using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
        abstract class IColleague
        {
                public IColleague(IMediator mediator)
                {
                        this.mediator = mediator;
                }

                protected void Changed()
                {
                        this.mediator.ColleagueChanged(this);
                }

                IMediator mediator;
        }
}
