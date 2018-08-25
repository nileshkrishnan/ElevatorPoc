using System;

namespace Elavator.Lib
{
    public abstract class Button : GenericSet
    {

        protected ButtonState _state;

        public ButtonState State { get => _state; }

        protected abstract void TriggerAction();

        public void PerformButtonPress(ButtonAction action, params object[] parameters)
        {
            // Validate or guard input

            // Assign the button state here;


            //perfoam actual work
            TriggerAction();
        }
    }
}
