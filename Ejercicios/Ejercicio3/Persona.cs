using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Persona
    {
        private string _curp;
        private string _nombre;
        private string _apellido_paterno;
        private string _apellido_materno;
        private string _email;
        
        public Persona(string curp,
            string nombre, 
            string apellido_paterno,
            string apellido_materno, 
            string email)
        {
            this.curp = curp;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.email = email;
        }

        public string curp
        {
            get { return _curp; }
            set { _curp = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string apellido_paterno {
            get { return _apellido_paterno; }
            set { _apellido_paterno = value; }
        }

        public string apellido_materno
        {
            get { return _apellido_materno; }
            set { _apellido_materno = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
