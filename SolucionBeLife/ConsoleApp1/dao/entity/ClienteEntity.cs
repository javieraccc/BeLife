using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class ClienteEntity
    {       

        private string nombres;
        private string apellidos;
        private string rut;
        private DateTime fechaNacimiento;
        private SexoEntity sexo;
        private EstadoCivilEntity estadoCivil;

        public ClienteEntity()
        {
                
        }

        public EstadoCivilEntity EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }


        public SexoEntity Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }


        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }





    }
}
