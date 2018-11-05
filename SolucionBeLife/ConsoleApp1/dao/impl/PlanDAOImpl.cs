
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.BeLifeDataSetTableAdapters;
using Persistencia.dao.entity;

namespace Persistencia.dao.impl
{
    public class PlanDAOImpl : PlanDAO
    {
        private PlanTableAdapter adapter;

        public PlanDAOImpl()
        {
            adapter = new PlanTableAdapter();
        }

        public void create(PlanEntity plan)
        {
            adapter.Insert(plan.IdPlan, plan.NombrePlan, plan.PrimaBase, plan.PolizaActual);
        }

        public void delete(PlanEntity plan)
        {
            adapter.Delete(plan.IdPlan, plan.NombrePlan, plan.PrimaBase, plan.PolizaActual);
        }

        public List<PlanEntity> findAll()
        {
            List<PlanEntity> planes = new List<PlanEntity>();

            foreach (BeLifeDataSet.PlanRow row in adapter.GetData().Rows)
            {
                PlanEntity plan = new PlanEntity();
                plan.IdPlan = row.IdPlan;
                plan.NombrePlan = row.Nombre;
                plan.PrimaBase = row.PrimaBase;
                plan.PolizaActual = row.PolizaActual;

                planes.Add(plan);
            }
            return planes;
        }

        public void update(PlanEntity plan)
        {
            throw new NotImplementedException();
        }
    }
}
