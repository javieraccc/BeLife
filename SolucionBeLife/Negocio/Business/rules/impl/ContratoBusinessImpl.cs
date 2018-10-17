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
    public class ContratoBusinessImpl : ContratoBusiness
    {
        public static readonly ContratoDAO dao = new ContratoDAOImpl();

        public void create(ContratoEntity contrato)
        {
            dao.create(contrato);
        }

        public void delete(ContratoEntity contrato)
        {
            dao.create(contrato);
        }

        public List<ContratoEntity> listContrato()
        {
            return dao.findAll();
        }

        public void update(ContratoEntity contrato)
        {
            dao.update(contrato);
        }
    }
}
