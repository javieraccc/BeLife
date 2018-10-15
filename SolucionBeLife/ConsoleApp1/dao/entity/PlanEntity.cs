using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.dao.entity
{
    public class PlanEntity
    {
        private string idPlan;
        private string nombrePlan;
        private float primaBase;
        private string polizaActual;

        public PlanEntity()
        {

        }

        public string PolizaActual
        {
            get { return polizaActual; }
            set { polizaActual = value; }
        }


        public float PrimaBase
        {
            get { return primaBase; }
            set { primaBase = value; }
        }


        public string NombrePlan
        {
            get { return nombrePlan; }
            set { nombrePlan = value; }
        }


        public string IdPlan
        {
            get { return idPlan; }
            set { idPlan = value; }
        }

    }
}
