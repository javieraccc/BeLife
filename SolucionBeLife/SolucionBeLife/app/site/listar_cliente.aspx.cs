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
    public partial class listar_cliente : System.Web.UI.Page
    {
        private static readonly ClienteBusiness clienteBusiness = new ClienteBusinessImpl();
                
        private List<ClienteEntity> clientes = clienteBusiness.listCliente();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void refrescarTabla()
        {
            tbl_clientes.DataSource = clientes;
            tbl_clientes.DataBind();
        }

        protected void btn_listar_clientes_Click(object sender, EventArgs e)
        {
            refrescarTabla();
        }
    }
}