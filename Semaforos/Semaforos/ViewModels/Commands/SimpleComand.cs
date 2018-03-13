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

        public ViewModelBase ViewModelBase { get; set; }

        public SimpleComand(ViewModelBase viewModel)
        {
            this.ViewModelBase = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModelBase.SimpreMethod();
        }
    }
}
