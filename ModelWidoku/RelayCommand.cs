﻿using System;
using System.Windows.Input;

namespace MVVMtest.ModelWidoku
{
    public class RelayCommand : ICommand {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;
        public event EventHandler CanExecuteChanged {
            add {
                if (_canExecute != null) CommandManager.RequerySuggested += value;
            }
            remove {
                if (_canExecute != null) CommandManager.RequerySuggested -= value;
            }
        }

        //KONSTRUKTOR
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null) {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter) {
            _execute(parameter);
        }
    }
}
