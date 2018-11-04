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
    public partial class registrar_cliente : System.Web.UI.Page
    {
        private static readonly ClienteBusiness clienteBusiness =
            new ClienteBusinessImpl();

        private static readonly EstadoCivilBusiness estadoCivilBusiness =
            new EstadoCivilBusinessImpl();

        private static readonly SexoBusiness sexoBusiness =
            new SexoBusinessImpl();

        private List<EstadoCivilEntity> estados;
        private List<SexoEntity> sexos;

        protected void Page_Load(object sender, EventArgs e)
        {
            estados = estadoCivilBusiness.listEstado();
            sexos = sexoBusiness.listSexo();

            if (!IsPostBack)
            {
                cmb_estado_civil.DataSource = estados;
                cmb_estado_civil.DataBind();

                cmb_sexo.DataSource = sexos;
                cmb_sexo.DataBind();

            }

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                validar();

                ClienteEntity nuevoCliente = new ClienteEntity();
                nuevoCliente.Nombres = txt_nombres.Text;
                nuevoCliente.Apellidos = txt_apellidos.Text;
                nuevoCliente.Rut = txt_rut.Text;
                nuevoCliente.FechaNacimiento = DateTime.Parse(txt_fecha_nacimiento.Text);
                SexoEntity sexoSelect = sexos.FirstOrDefault(
                    sexos => sexos.Id == Int32.Parse(cmb_sexo.SelectedValue));
                SexoEntity nuevoSexo = new SexoEntity();
                nuevoSexo.Id = sexoSelect.Id;
                nuevoSexo.Descripcion = sexoSelect.Descripcion;
                nuevoCliente.Sexo = nuevoSexo;
                EstadoCivilEntity estadoSelect = estados.FirstOrDefault(
                    estados => estados.Id == Int32.Parse(cmb_estado_civil.SelectedValue));
                EstadoCivilEntity nuevoEstado = new EstadoCivilEntity();
                nuevoEstado.Id = estadoSelect.Id;
                nuevoEstado.Descripcion = estadoSelect.Descripcion;
                nuevoCliente.EstadoCivil = nuevoEstado;

                clienteBusiness.create(nuevoCliente);

                lbl_mensaje.Text = "Cliente registrado exitosamente.";
                lbl_mensaje.CssClass = "green-mesage";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = ex.Message;
                lbl_mensaje.CssClass = "red-message";
            }

        }

        public void validar()
        {
            string error = "";

            if ("".Equals(txt_nombres.Text))
            {
                error = error + "<p>- Debe ingresar información en campo Nombres </p>";
            }
            else if (txt_nombres.Text.Length > 60)
            {
                error = error + "<p>- Nombres debe tener máximo 60 caracteres</p>";
            }

            if ("".Equals(txt_apellidos.Text))
            {
                error = error + "<p>- Debe ingresar los Apellidos </p>";
            }
            else if (txt_apellidos.Text.Length > 60)
            {
                error = error + "<p>- Apellido Paterno debe tener máximo 60 caracteres</p>";
            }            

            if ("".Equals(txt_fecha_nacimiento.Text))
            {

                error = error + "<p>- Debe ingresar información en campo Fecha </p>";
            }
            else if (DateTime.Parse("01-01-2000").CompareTo(DateTime.Parse(txt_fecha_nacimiento.Text)) < 0)
            //else if (DateTime.Today.CompareTo(DateTime.Parse(txt_fecha_nacimiento.Text)) < 0)
            {
                error = error + "<p>- El nuevo empleado debe ser mayor de edad</p>";
            }

            if (!"".Equals(error))
            {
                throw new Exception(error);
            }
        }
    }
}