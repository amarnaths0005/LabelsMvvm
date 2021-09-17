using System;
using System.Windows.Input;

namespace Labels.ViewModel
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;

        public DelegateCommand(Action action)
        {
            // Put the Action (basically a void method) passed as a parameter into our private field _action, where it can be run by the Execute function when the command is called
            _action = action;
        }

        public void Execute(object parameter)
        {
            _action();
        }


        public bool CanExecute(object parameter)
        {
            return true; // For now
        }

        // This essentially means when someone subscribes to this event, do nothing, since the event never needs to fire (because CanExecute is always true).
#pragma warning disable 67
        public event EventHandler CanExecuteChanged { add { } remove { } }
#pragma warning restore 67
    }
}
