using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Business.rules
{
    public interface ContratoBusiness
    {
        void create(ContratoEntity contrato);

        void update(ContratoEntity contrato);

        void delete(ContratoEntity contrato);

        List<ContratoEntity> listContrato();
    }
}
