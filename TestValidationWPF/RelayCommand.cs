using System.Windows.Input;
using System;

namespace TestValidation {

    internal class RelayCommand : ICommand {

        public Action<object> execute { get; set; }

        private Func<object, bool> canExecute { get; set; }

        public event EventHandler CanExecuteChanged {

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) {

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute) {

            this.execute = execute;
            this.canExecute = o => true;
        }

        public bool CanExecute(object parameter) {

            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter) {

            execute(parameter);
        }
    }
}