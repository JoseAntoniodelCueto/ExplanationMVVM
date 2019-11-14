using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MyFirstMVVM.ViewModel.Base
{
    //Para la implementación de RelayCommand creamos dos implementaciones una con un parametro generico y otra sin él.
    //Mientras que la implementación con generico, nos permitirá poder enviar un parametro y poder castearlo al tipo deseado
    //La implementación sin comando estará más orientada a acciones (Comandos) que no requieran de parametro en su defecto.

    public class RelayCommand : ICommand
    {
        private Action _action;
        private Func<bool> _canExecuteAction;

        public RelayCommand(Action action, Func<bool> canExecuteAction = null)
        {
            _action = action;
            _canExecuteAction = canExecuteAction;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if(_canExecuteAction != null)
            {
                return  _canExecuteAction.Invoke();
            }
            else
            {
                return true;
            }            
        }

        public void RaiseCanExecute()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }
    }

    public class RelayCommand<T> : ICommand
    {
        public RelayCommand(Action<T> action)
        {
            _action = action;
        }

        private Action<T> _action;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action.Invoke((T)Convert.ChangeType(parameter, typeof(T)));
        }
    }
}
