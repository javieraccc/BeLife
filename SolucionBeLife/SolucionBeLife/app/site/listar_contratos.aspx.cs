using Negocio.Business.rules;
using Negocio.Business.rules.impl;
using Persistencia.dao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolucionBeLife.app.site
{
    public partial class listar_contratos : System.Web.UI.Page
    {
        private static readonly ContratoBusiness contratoBusiness = new ContratoBusinessImpl();

        private List<ContratoEntity> contratos = contratoBusiness.listContrato();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void refrescarTabla()
        {
            tbl_contratos.DataSource = contratos;
            tbl_contratos.DataBind();
        }

        protected void btn_listar_contratos_Click(object sender, EventArgs e)
        {
            refrescarTabla();
        }
    }
}