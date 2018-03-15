using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Semaforos.ViewModels.Commands
{
    public class SimpleComand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _ejecutar;

        public SimpleComand(Action action)
        {
            _ejecutar = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _ejecutar.Invoke();
        }
    }
}
