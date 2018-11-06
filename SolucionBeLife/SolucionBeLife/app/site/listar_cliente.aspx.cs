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

        private List<ClienteEntity> clientes;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarClientes()
        {
            clientes = clienteBusiness.listCliente();
        }

        private void refrescarTabla()
        {
            cargarClientes();
            tbl_clientes.DataSource = clientes;
            tbl_clientes.DataBind();
        }

        protected void btn_listar_clientes_Click(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        protected void tbl_clientes_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void tbl_clientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)tbl_clientes.Rows[e.RowIndex];
            string rut = row.Cells[0].Text;
            ClienteEntity deleteCliente = new ClienteEntity();
            deleteCliente.Rut = rut;
            clienteBusiness.delete(deleteCliente);

            refrescarTabla();

        }

        protected void tbl_clientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void tbl_clientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            tbl_clientes.EditIndex = -1;
            refrescarTabla();

        }
    }
}