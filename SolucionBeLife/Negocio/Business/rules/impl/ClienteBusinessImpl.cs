using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao;
using Persistencia.dao.impl;
using Persistencia.dao.entity;

namespace Negocio.Business.rules.impl
{
    public class ClienteBusinessImpl : ClienteBusiness
    {
        public static readonly ClienteDAO dao = new ClienteDAOImpl();

        public void create(ClienteEntity cliente)
        {
            dao.create(cliente);
        }

        public void delete(ClienteEntity cliente)
        {
            dao.delete(cliente);
        }

        public List<ClienteEntity> listCliente()
        {
            return dao.findAll();
        }

        public void update(ClienteEntity cliente)
        {
            dao.update(cliente);
        }
    }
}
