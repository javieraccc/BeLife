using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Business.rules
{
    public interface ClienteBusiness
    {
        void create(ClienteEntity cliente);

        void update(ClienteEntity cliente);

        void delete(ClienteEntity cliente);

        List<ClienteEntity> listCliente();
    }
}
