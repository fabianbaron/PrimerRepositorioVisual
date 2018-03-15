using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Semaforos.ViewModels.Commands
{
    public class Parametro : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<String> _ejecutar;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="viewModel"></param>
        public Parametro(Action<String> action)
        {
            _ejecutar = action;
        }                      

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                var s = parameter as String;
                if (String.IsNullOrEmpty(s))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            _ejecutar.Invoke(parameter as String);
        }
    }
}
