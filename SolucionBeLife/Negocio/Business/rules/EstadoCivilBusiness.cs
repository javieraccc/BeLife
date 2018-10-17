using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Business.rules
{
    public interface EstadoCivilBusiness
    {
        void create(EstadoCivilEntity estadoCivil);

        void update(EstadoCivilEntity estadoCivil);

        void delete(EstadoCivilEntity estadoCivil);

        List<EstadoCivilEntity> listContrato();
    }
}
