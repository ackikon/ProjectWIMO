using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestNewDesign.ViewModel.HelperViewModel
{
    class Command : ICommand //Данный класс служит для получения свойств кнопки Command
    {
        public event EventHandler CanExecuteChanged ///Событие привязки поведения на добавление и удаление свойств
        {
            add { CommandManager.RequerySuggested += value;}
            remove { CommandManager.RequerySuggested -= value; }
        }

        readonly Action<object> execute;
        readonly Func<object, bool> canExecute;

        public Command(Action<object> executeAction, Func<object, bool> canExecuteFunc = null)
        {
            execute = executeAction;
            canExecute = canExecuteFunc;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute != null) return canExecute(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
