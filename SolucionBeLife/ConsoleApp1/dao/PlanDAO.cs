using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.dao
{
    public interface PlanDAO
    {
        List<PlanEntity> findAll();

        void create(PlanEntity cliente);

        void delete(PlanEntity cliente);

        void update(PlanEntity cliente);
    }
}
