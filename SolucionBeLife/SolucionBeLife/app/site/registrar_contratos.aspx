<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="registrar_contratos.aspx.cs" Inherits="SolucionBeLife.app.site.registrar_contratos" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Registrar Contratos</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">

    <div class="row">
        <div class="col-50">
            <span>FECHA CREACION</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_fecha_creacion" runat="server" TextMode="Date" >
            </asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>RUT CLIENTE</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_rut_cliente" runat="server" TextMode="Number"
                value="" placeholder="00000000-0">
            </asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>PLAN</span>
        </div>
        <div class="col-50">
            <asp:DropDownList ID="cmb_planes" runat="server" DataValueField="idPlan"
               DataTextField="nombrePlan">
            </asp:DropDownList>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>INICIO VIGENCIA</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_inicio_vigencia" runat="server" TextMode="Date" >
            </asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-50">
            <span>FIN VIGENCIA</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_fin_vigencia" runat="server" TextMode="Date" >
            </asp:TextBox>
        </div>
    </div>
</asp:Content>
