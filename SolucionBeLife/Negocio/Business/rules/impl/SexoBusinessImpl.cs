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
    public class SexoBusinessImpl : SexoBusiness
    {
        public static readonly SexoDAO dao = new SexoDAOImpl();

        public void create(SexoEntity sexo)
        {
            dao.create(sexo);
        }

        public void delete(SexoEntity sexo)
        {
            dao.delete(sexo);
        }

        public List<SexoEntity> listSexo()
        {
            return dao.findAll();
        }

        public void update(SexoEntity sexo)
        {
            dao.update(sexo);
        }
    }
}
