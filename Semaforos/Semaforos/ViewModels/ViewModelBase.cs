using Semaforos.Models;
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
        private ClienteModel Cliente = new ClienteModel();
        
        public String LblNombre
        {
            get { return Cliente.Nombre; }
            set { Cliente.Nombre = value; }
        }

        public String LblSueldo
        {
            get { return Cliente.Sueldo.ToString(); }
            set { Cliente.Sueldo = Convert.ToInt16(value); }
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

    }
}
