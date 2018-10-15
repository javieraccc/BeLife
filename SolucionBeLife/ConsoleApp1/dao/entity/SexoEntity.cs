using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.dao.entity
{
    public class SexoEntity
    {
        private string id;
        private string descripcion;

        public SexoEntity()
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
