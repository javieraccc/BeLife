<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="registrar_cliente.aspx.cs" Inherits="SolucionBeLife.app.site.registrar_cliente" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Registrar Clientes</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-50">
            <span>NOMBRES</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_nombres" runat="server"
                value="" placeholder="Nombres">
            </asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>APELLIDOS</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_apellidos" runat="server"
                value="" placeholder="Apellidos">
            </asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>RUT</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_rut" runat="server" TextMode="Number"
                value="" placeholder="00000000-0">
            </asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>FECHA DE NACIMIENTO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_fecha_nacimiento" runat="server" TextMode="Date" >
            </asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>SEXO</span>
        </div>
        <div class="col-50">
            <asp:DropDownList ID="cmb_sexo" runat="server" DataValueField="Id"
               DataTextField="Descripcion">
            </asp:DropDownList>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>ESTADO CIVIL</span>
        </div>
        <div class="col-50">
            <asp:DropDownList ID="cmb_estado_civil" runat="server" DataValueField="Id"
               DataTextField="Descripcion">
            </asp:DropDownList>
        </div>
    </div>

    <div class="row">
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        <div class="col-25 green-button">
            <asp:Button ID="btn_registrar" runat="server"
                Text="CREAR" OnClick="btn_registrar_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="col-100">
            <asp:Label ID="lbl_mensaje" runat="server" />
        </div>
    </div>
</asp:Content>
