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
        public SimpleComand SimpleComand { get; private set; }
        public Parametro Parametro { get; private set; }

        public ViewModelBase()
        {
            SimpleComand = new SimpleComand(SimpreMethod);
            Parametro = new Parametro(ParameterMethod);
        }

        public void SimpreMethod()
        {
            Debug.WriteLine("Comando...");
        }

        public void ParameterMethod(String parametro)
        {
            Debug.WriteLine(parametro);
        }
    }
}
