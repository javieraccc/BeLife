<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="listar_contratos.aspx.cs" Inherits="SolucionBeLife.app.site.listar_contratos" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Lista de Clientes</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        <div class="col-25 green-button">
            <asp:Button ID="btn_listar_contratos" runat="server"
                Text="Listar"  OnClick="btn_listar_contratos_Click"/>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="tbl_contratos" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Num Contrato" DataField="NumeroContratos" ReadOnly="true"/>
                <asp:BoundField HeaderText="Rut Cliente" DataField="RutCliente" ReadOnly="true"/>
                <asp:BoundField HeaderText="Codigo Plan" DataField="CodigoPlan" ReadOnly="true"/>
                <asp:BoundField HeaderText="Estado" DataField="EstadoVigente" ReadOnly="true"/>
                <asp:BoundField HeaderText="Declaracion Salud" DataField="DeclaracionSalud" ReadOnly="true"/>
                <asp:BoundField HeaderText="Primas Anual" DataField="PrimaAnual" ReadOnly="true"/>
                <asp:BoundField HeaderText="Primas Mensual" DataField="PrimaMensual" ReadOnly="true"/>
                <asp:BoundField HeaderText="Fecha Ceacion Contrato" DataField="FechaCreacion" DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha Termino Contrato" DataField="FechaTermino" DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />
                <asp:BoundField HeaderText="Vigencia" DataField="InicioVigencia" DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />
                <asp:BoundField HeaderText="Fin de Vigencia" DataField="FinVigencia" DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />
            </Columns>
        </asp:GridView>
        
    </div>
    
</asp:Content>