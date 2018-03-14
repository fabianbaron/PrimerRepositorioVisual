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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="viewModel"></param>
        public Parametro(ViewModelBase viewModel)
        {
            this.ModelBase = viewModel;
        }

        public event EventHandler CanExecuteChanged;

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
            this.ModelBase.ParameterMethod(parameter as String);
        }
    }
}
