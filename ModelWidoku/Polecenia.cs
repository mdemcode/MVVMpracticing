﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMtest.ModelWidoku {
    public class PolecenieZmien : ICommand {

        private readonly WidokGlowny wg;
        public event EventHandler CanExecuteChanged;

        public PolecenieZmien(WidokGlowny widok) {
            wg = widok ?? throw new ArgumentNullException("widok");
        }

        public bool CanExecute(object parameter) {
            return true;
        }
        public void Execute(object parameter) {
            wg.Zlecenia = 1m;
            wg.Grupy = 1m;
            wg.Elementy = 1m;
        }
    }
}
