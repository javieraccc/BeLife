using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.dao;
using Persistencia.dao.entity;
using Persistencia.dao.impl;

namespace Negocio.Business.rules.impl
{
    public class EstadoCivilBusinessImpl : EstadoCivilBusiness
    {
        public static readonly EstadoCivilDAO dao = new EstadoCivilDAOImpl();

        public void create(EstadoCivilEntity estadoCivil)
        {
            dao.create(estadoCivil);
        }

        public void delete(EstadoCivilEntity estadoCivil)
        {
            dao.delete(estadoCivil);
        }

        public List<EstadoCivilEntity> listContrato()
        {
            return dao.findAll();
        }

        public void update(EstadoCivilEntity estadoCivil)
        {
            dao.update(estadoCivil);
        }
    }
}
