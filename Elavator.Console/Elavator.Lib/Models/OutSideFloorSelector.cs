using Elavator.Lib.Entities;
using Elavator.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elavator.Lib
{
    public class OutSideFloorSelectorButton : Button, IButton
    {
        public ButtonType SelectedButton { get; set; }

        public OutSideFloorSelectorButton()
        {

        }

        protected override void TriggerAction()
        {
            throw new NotImplementedException();
        }

        Task IButton.ProcessButtonSelected()
        {
            TriggerAction();
            throw new NotImplementedException();
        }
    }
}
