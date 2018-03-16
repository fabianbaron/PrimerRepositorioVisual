using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Semaforos.Models
{
    class ClienteModel
    {
        private String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private Int16 _Sueldo;

        public Int16 Sueldo
        {
            get { return _Sueldo; }
            set { _Sueldo = value; }
        }

        private String _EstadoCivil;

        public String EstadoCivil
        {
            get { return _EstadoCivil; }
            set { _EstadoCivil = value; }
        }

        public ClienteModel()
        {
            _Nombre = "Fabián";
            _Sueldo = 3000;
            _EstadoCivil = "Soltero";
        }
    }
}
