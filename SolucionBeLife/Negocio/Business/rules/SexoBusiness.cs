using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Business.rules
{
    public interface SexoBusiness
    {
        void create(SexoEntity sexo);

        void update(SexoEntity sexo);

        void delete(SexoEntity sexo);

        List<SexoEntity> listSexo();
    }
}
