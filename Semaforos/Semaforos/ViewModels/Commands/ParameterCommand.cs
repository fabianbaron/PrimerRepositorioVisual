using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Semaforos.ViewModels.Commands
{
    public class ParameterCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ViewModelBase ModelBase { get; set; }

        public ParameterCommand( ViewModelBase viewModel)
        {
            this.ModelBase = viewModel;
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
            ModelBase.Parameter(parameter as String);
        }
    }
}
