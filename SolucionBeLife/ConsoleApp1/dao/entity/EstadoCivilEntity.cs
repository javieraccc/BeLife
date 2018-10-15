using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.dao.entity
{
    public class EstadoCivilEntity
    {        

        private string id;
        private string descripcion;

        public EstadoCivilEntity()
        {

        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }



    }
}
