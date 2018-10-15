using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.dao.entity
{
    public class ContratoEntity
    {
        private string numeroContrato;
        private DateTime fechaCreacion;
        private DateTime fechaTermino;
        private ClienteEntity rutCliente;
        private PlanEntity codigoPlan;
        private DateTime inicioVigencia;
        private DateTime finVigencia;
        private bool estadoVigente;
        private bool declaracionSalud;
        private float primaAnual;
        private float primaMensual;
        private string observaciones;

        public ContratoEntity()
        {

        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }


        public float PrimaMensual
        {
            get { return primaMensual; }
            set { primaMensual = value; }
        }


        public float PrimaAnual
        {
            get { return primaAnual; }
            set { primaAnual = value; }
        }


        public bool DeclaracionSalud
        {
            get { return declaracionSalud; }
            set { declaracionSalud = value; }
        }


        public bool EstadoVigente
        {
            get { return estadoVigente; }
            set { estadoVigente = value; }
        }


        public DateTime FinVigencia
        {
            get { return finVigencia; }
            set { finVigencia = value; }
        }


        public DateTime InicioVigencia
        {
            get { return inicioVigencia; }
            set { inicioVigencia = value; }
        }


        public PlanEntity CodigoPlan
        {
            get { return codigoPlan; }
            set { codigoPlan = value; }
        }


        public ClienteEntity RutCliente
        {
            get { return rutCliente; }
            set { rutCliente = value; }
        }


        public DateTime FechaTermino
        {
            get { return fechaTermino; }
            set { fechaTermino = value; }
        }


        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }


        public string NumeroContrato
        {
            get { return numeroContrato; }
            set { numeroContrato = value; }
        }

    }
}
