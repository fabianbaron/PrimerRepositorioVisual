using Semaforos.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforos.ViewModels
{
    public class ViewModelBase
    {
        public SimpleComand SimpleComand { get; set; }

        public ViewModelBase()
        {
            this.SimpleComand = new SimpleComand(this);
        }

        public void SimpreMethod()
        {
            Debug.WriteLine("Comando...");
        }
    }
}
