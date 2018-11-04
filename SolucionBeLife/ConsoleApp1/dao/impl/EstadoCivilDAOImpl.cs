using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.BeLifeDataSetTableAdapters;
using Persistencia.dao.entity;

namespace Persistencia.dao.impl
{
    public class EstadoCivilDAOImpl : EstadoCivilDAO
    {
        private EstadoCivilTableAdapter adapter;

        public EstadoCivilDAOImpl()
        {
            adapter = new EstadoCivilTableAdapter();
        }

        public void create(EstadoCivilEntity estadoCivil)
        {
            adapter.Insert(estadoCivil.Id, estadoCivil.Descripcion);
        }

        public void delete(EstadoCivilEntity estadoCivil)
        {
            adapter.Delete(estadoCivil.Id, estadoCivil.Descripcion);
        }

        public List<EstadoCivilEntity> findAll()
        {
            List<EstadoCivilEntity> estados = new
                List<EstadoCivilEntity>();

            foreach (BeLifeDataSet.EstadoCivilRow row in 
                adapter.GetData().Rows)
            {
                EstadoCivilEntity estadoCivil = new EstadoCivilEntity();
                estadoCivil.Id = row.IdEstadoCivil;
                estadoCivil.Descripcion = row.Descripcion;
                estados.Add(estadoCivil);
            }
            return estados;
        }

        public void update(EstadoCivilEntity estadoCivil)
        {
            adapter.Update(estadoCivil.Descripcion, estadoCivil.Id, estadoCivil.Descripcion);
        }
    }
}
