using Semaforos.Models;
using Semaforos.ViewModels.Commands;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Semaforos.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private ClienteModel Cliente = new ClienteModel();

        ICommand _calcularImpuestoCommand;

        public ViewModelBase()
        {
            _calcularImpuestoCommand = new CalcularImpuestoCommand(CalculoImpuesto);
        }

        public ICommand CalcularImpuestoComm { get { return _calcularImpuestoCommand; } }
        
        public double Impuesto
        {
            get { return Cliente.Impuesto; }
        }
        
        public String LblNombre
        {
            get { return Cliente.Nombre; }
            set { Cliente.Nombre = value; }
        }

        public String LblSueldo
        {
            get { return Cliente.Sueldo.ToString(); }
            set
            {
                Cliente.Sueldo = Convert.ToInt16(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ColorDeFondoSueldo"));
            }
        }

        public bool ChkEstadoCivil
        {
            get
            {
                if (Cliente.EstadoCivil.Equals("Casado"))
                {
                    return true;
                }
                return false;
            }

            set 
            {
                if(value)
                {
                    Cliente.EstadoCivil = "Casado";
                }
                else
                {
                    Cliente.EstadoCivil = "Soltero";
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChkEstadoCivil"));
            }
        }
        
        public String ColorDeFondoSueldo
        {
            get
            {
                if (Cliente.Sueldo >= 2000)
                {
                    return "LightGreen";
                }
                else if (Cliente.Sueldo > 1500)
                {
                    return "Yellow";
                }
                return "Red";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void CalculoImpuesto()
        {
            Cliente.CalcularImpuesto();
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Impuesto"));
            }
        }
    }
}
