using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao;
using Persistencia.dao.entity;
using Persistencia.dao.impl;

namespace Negocio.Business.rules.impl
{
    public class PlanBusinessImpl : PlanBusiness
    {
        public static readonly PlanDAO dao = new PlanDAOImpl();

        public void create(PlanEntity plan)
        {
            dao.create(plan);
        }

        public void delete(PlanEntity plan)
        {
            dao.delete(plan);
        }

        public List<PlanEntity> listPlan()
        {
            return dao.findAll();
        }

        public void update(PlanEntity plan)
        {
            dao.update(plan);
        }
    }
}
