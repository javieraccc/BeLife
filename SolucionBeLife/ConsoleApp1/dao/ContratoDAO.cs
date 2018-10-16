using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.dao
{
    public interface ContratoDAO
    {
        List<ContratoEntity> findAll();

        void create(ContratoEntity cliente);

        void delete(ContratoEntity cliente);

        void update(ContratoEntity cliente);
    }
}
