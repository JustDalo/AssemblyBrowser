using System;
using System.Windows.Input;

namespace AssemblyBrowser
{
    public class AssemblyBrowserCommand : ICommand
    {
        //region Fields 
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}