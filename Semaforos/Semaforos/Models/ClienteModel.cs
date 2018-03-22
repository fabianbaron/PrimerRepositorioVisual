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
            _Sueldo = 0;
            _EstadoCivil = "Soltero";
        }

        private double _Impuesto;

        public double Impuesto
        {
            get { return _Impuesto; }
        }

        public void CalcularImpuesto()
        {
            if (_Sueldo > 2000)
            {
                _Impuesto = 20;
            }
            else if (_Sueldo > 1000)
            {
                _Impuesto = 10;
            }
            else
            {
                _Impuesto = 5;
            }
        }
    }
}
