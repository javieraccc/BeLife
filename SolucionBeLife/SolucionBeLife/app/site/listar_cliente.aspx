<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="listar_cliente.aspx.cs" Inherits="SolucionBeLife.app.site.listar_cliente" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Lista de Clientes</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        <div class="col-50 green-button">
            <asp:Button ID="btn_listar_clientes" runat="server"
                Text="Listar"  OnClick="btn_listar_clientes_Click"/>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="tbl_clientes" runat="server" 
            OnRowEditing ="tbl_clientes_RowEditing"
            OnRowDeleting ="tbl_clientes_RowDeleting"
            OnRowUpdating ="tbl_clientes_RowUpdating"
            OnRowCancelingEdit ="tbl_clientes_RowCancelingEdit"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Rut" DataField="Rut" ReadOnly="true"/>
                <asp:BoundField HeaderText="Nombres" DataField="Nombres" ReadOnly="true"/>
                <asp:BoundField HeaderText="Apellidos" DataField="Apellidos" ReadOnly="true"/>
                <asp:BoundField HeaderText="Sexo" DataField="Sexo.Descripcion" ReadOnly="true"/>
                <asp:BoundField HeaderText="Estado Civil" DataField="EstadoCivil.Descripcion" ReadOnly="true"/>
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento"
                    DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />

                <asp:TemplateField HeaderText="" ItemStyle-CssClass="skyblue-button">
                    <ItemTemplate>
                        <asp:Button ID="btn_edit" runat="server"
                            Text="EDITAR" CommandName="Edit" />
                    </ItemTemplate>
                   <EditItemTemplate>
                        <div class="skyblue-button">
                            <asp:Button ID="btn_update" 
                                runat="server" Text="UPDATE" CommandName="Update" />
                        </div>
                        <div class="yellow-button">
                            <asp:Button ID="btn_cancel" CssClass="red-button"
                                runat="server" Text="CANCEL" CommandName="Cancel" />
                        </div>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="" ItemStyle-CssClass="red-button">
                    <ItemTemplate>
                        <asp:Button ID="btn_delete" runat="server"
                            Text="ELIMINAR" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
             </Columns>
        </asp:GridView>
        
    </div>
    
</asp:Content>
