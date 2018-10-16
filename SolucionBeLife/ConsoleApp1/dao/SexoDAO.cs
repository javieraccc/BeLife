using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.dao
{
    public interface SexoDAO
    {
        List<SexoEntity> findAll();

        void create(SexoEntity cliente);

        void delete(SexoEntity cliente);

        void update(SexoEntity cliente);
    }
}
