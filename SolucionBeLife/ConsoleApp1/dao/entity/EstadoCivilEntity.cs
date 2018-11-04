using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class EstadoCivilEntity
    {        

        private int id;
        private string descripcion;

        public EstadoCivilEntity()
        {

        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



    }
}
