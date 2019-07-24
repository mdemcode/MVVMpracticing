using System;
using System.Windows.Input;

namespace MVVMtest.ModelWidoku
{
    public class PolecenieZmien : ICommand {
        private readonly WidokGlowny wg;
        public event EventHandler CanExecuteChanged {
            add {
                CommandManager.RequerySuggested += value;
            }
            remove {
                CommandManager.RequerySuggested -= value;
            }
        }
        public PolecenieZmien(WidokGlowny widok) {
            wg = widok ?? throw new ArgumentNullException("widok");
        }
        public bool CanExecute(object parameter) {
            return wg.Zlecenia >= 0m;
        }
        public void Execute(object parameter) {
            wg.Zlecenia = 1m;
            wg.Grupy = 2m;
            wg.Elementy = 3m;
        }
    }
}
