using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.BeLifeDataSetTableAdapters;
using Persistencia.dao.entity;

namespace Persistencia.dao.impl
{
    public class ClienteDAOImpl : ClienteDAO
    {
        private ClienteTableAdapter adapter;

        public ClienteDAOImpl()
        {
            adapter = new ClienteTableAdapter();
        }

        public void create(ClienteEntity cliente)
        {
            adapter.Insert(cliente.Rut, cliente.Nombres, cliente.Apellidos, cliente.FechaNacimiento,
                cliente.Sexo.Id, cliente.EstadoCivil.Id);
        }

        public void delete(ClienteEntity cliente)
        {
            adapter.Delete(cliente.Rut, cliente.Nombres, cliente.Apellidos, cliente.FechaNacimiento,
                cliente.Sexo.Id, cliente.EstadoCivil.Id);
        }

        public List<ClienteEntity> findAll()
        {
            List<ClienteEntity> clientes = new List<ClienteEntity>();

            EstadoCivilDAO daoEstado = new EstadoCivilDAOImpl();
            List<EstadoCivilEntity> estados = daoEstado.findAll();

            SexoDAO daoSexo = new SexoDAOImpl();
            List<SexoEntity> sexos = daoSexo.findAll();

            foreach (BeLifeDataSet.ClienteRow row in 
                adapter.GetData().Rows)
            {
                ClienteEntity cliente = new ClienteEntity();

                cliente.Rut = row.RutCliente;
                cliente.Nombres = row.Nombres;
                cliente.Apellidos = row.Apellidos;
                cliente.EstadoCivil = estados.FirstOrDefault(
                    estado => estado.Id == row.IdEstadoCivil);
                cliente.FechaNacimiento = row.FechaNacimiento;
                cliente.Sexo = sexos.FirstOrDefault(
                    sexo => sexo.Id == row.IdSexo);

                clientes.Add(cliente);                
            }
            return clientes;
        }

        public void update(ClienteEntity cliente)
        {
            throw new NotImplementedException();
        }
    }
}
