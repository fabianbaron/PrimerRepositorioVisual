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
        public ViewModelBase ModelBase { get; set; }

        public event EventHandler CanExecuteChanged;

        public Parametro(ViewModelBase viewModel)
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
                    return true;
                }
                return false;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            this.ModelBase.ParameterMethod(parameter as String);
        }
    }
}
