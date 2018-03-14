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
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
