<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="listar_cliente.aspx.cs" Inherits="SolucionBeLife.app.site.listar_cliente" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Lista de Clientes</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        <div class="col-25 green-button">
            <asp:Button ID="btn_listar_clientes" runat="server"
                Text="Listar"  OnClick="btn_listar_clientes_Click"/>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="tbl_clientes" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Rut" DataField="Rut" ReadOnly="true"/>
                <asp:BoundField HeaderText="Nombres" DataField="Nombres" ReadOnly="true"/>
                <asp:BoundField HeaderText="Apellidos" DataField="Apekkidos" ReadOnly="true"/>
                <asp:BoundField HeaderText="Sexo" DataField="Sexo" ReadOnly="true"/>
                <asp:BoundField HeaderText="Estado Civil" DataField="EstadoCivil" ReadOnly="true"/>
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento"
                    DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />
             </Columns>
        </asp:GridView>
        
    </div>
    
</asp:Content>
