using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.dao
{
    public interface EstadoCivilDAO
    {
        List<EstadoCivilEntity> findAll();

        void create(EstadoCivilEntity cliente);

        void delete(EstadoCivilEntity cliente);

        void update(EstadoCivilEntity cliente);
    }
}
