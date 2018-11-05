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
    public partial class registrar_contratos : System.Web.UI.Page
    {
        private static readonly ContratoBusiness contratoBusiness =
            new ContratoBusinessImpl();

        private static readonly PlanBusiness planBusiness =
            new PlanBusinessImpl();

        private List<PlanEntity> planes;

        protected void Page_Load(object sender, EventArgs e)
        {
            planes = planBusiness.listPlan();

            if (!IsPostBack)
            {
                cmb_planes.DataSource = planes;
                cmb_planes.DataBind();

            }

        }
    }
}