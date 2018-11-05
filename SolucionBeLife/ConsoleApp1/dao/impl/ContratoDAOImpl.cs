using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.BeLifeDataSetTableAdapters;
using Persistencia.dao.entity;

namespace Persistencia.dao.impl
{
    public class ContratoDAOImpl : ContratoDAO
    {
        private ContratoTableAdapter adapter;

        public ContratoDAOImpl()
        {
            adapter = new ContratoTableAdapter();
        }

        public void create(ContratoEntity contrato)
        {
            adapter.Insert(contrato.NumeroContrato, contrato.FechaCreacion, contrato.RutCliente.Rut, 
                contrato.CodigoPlan.IdPlan, contrato.InicioVigencia, contrato.FinVigencia, 
                contrato.EstadoVigente, contrato.DeclaracionSalud, contrato.PrimaAnual, 
                contrato.PrimaMensual, contrato.Observaciones);
        }

        public void delete(ContratoEntity contrato)
        {
            adapter.Delete(contrato.NumeroContrato, contrato.FechaCreacion, contrato.RutCliente.Rut,
                contrato.CodigoPlan.IdPlan, contrato.InicioVigencia, contrato.FinVigencia,
                contrato.EstadoVigente, contrato.DeclaracionSalud, contrato.PrimaAnual,
                contrato.PrimaMensual);
        }

        public List<ContratoEntity> findAll()
        {
            List<ContratoEntity> contratos = new List<ContratoEntity>();

            ClienteDAO daoClientes = new ClienteDAOImpl();
            List<ClienteEntity> clientes = daoClientes.findAll();

            foreach (BeLifeDataSet.ContratoRow row in adapter.GetData().Rows)
            {
                ContratoEntity contrato = new ContratoEntity();
                contrato.NumeroContrato = row.Numero;
                contrato.FechaCreacion = row.FechaCreacion;
                contrato.RutCliente.Rut = row.RutCliente;
                contrato.CodigoPlan.IdPlan = row.CodigoPlan;
                contrato.InicioVigencia = row.FechaInicioVigencia;
                contrato.FinVigencia = row.FechaFinVigencia;
                contrato.EstadoVigente = row.Vigente;
                contrato.DeclaracionSalud = row.DeclaracionSalud;
                contrato.PrimaAnual = row.PrimaAnual;
                contrato.PrimaMensual = row.PrimaMensual;
                contrato.Observaciones = row.Observaciones;

                contratos.Add(contrato);
            }
            return contratos;
        }

        public void update(ContratoEntity contrato)
        {
            throw new NotImplementedException();
        }
    }
}
