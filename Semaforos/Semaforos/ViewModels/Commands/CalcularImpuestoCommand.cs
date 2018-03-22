using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Semaforos.ViewModels.Commands
{
    class CalcularImpuestoCommand : ICommand
    {
        private Action _calcularImpuesto;

        public event EventHandler CanExecuteChanged;

        public CalcularImpuestoCommand(Action action)
        {
            _calcularImpuesto = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _calcularImpuesto.Invoke();
        }
    }
}
