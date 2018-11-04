using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.BeLifeDataSetTableAdapters;
using Persistencia.dao.entity;

namespace Persistencia.dao.impl
{
    public class SexoDAOImpl : SexoDAO
    {
        private SexoTableAdapter adapter;

        public SexoDAOImpl()
        {
            adapter = new SexoTableAdapter();           
        }

        public void create(SexoEntity sexo)
        {
            adapter.Insert(sexo.Id, sexo.Descripcion);
        }

        public void delete(SexoEntity sexo)
        {
            adapter.Delete(sexo.Id, sexo.Descripcion);
        }

        public List<SexoEntity> findAll()
        {
            List<SexoEntity> sexos = 
                new List<SexoEntity>();            

            foreach (BeLifeDataSet.SexoRow row in 
                adapter.GetData().Rows)
            {
                SexoEntity sexo = new SexoEntity();
                sexo.Id = row.IdSexo;
                sexo.Descripcion = row.Descripcion;
                sexos.Add(sexo);
            }
            return sexos;

        }

        public void update(SexoEntity sexo)
        {
            throw new NotImplementedException();
        }
    }
}
