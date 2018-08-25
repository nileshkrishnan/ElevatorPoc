using Elavator.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elavator.Lib.Entities
{
    public class InsideFloorSelector : Button, IButton
    {
        public InsideFloorSelector()
        {

        }

        protected override void TriggerAction()
        {
            throw new NotImplementedException();
        }

        async Task IButton.ProcessButtonSelected()
        {
            TriggerAction();

        }
    }
}
