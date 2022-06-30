<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Usuarios.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div>   
        <hr />
        <div>
            <label for="idControl">Listado de Usuarios</label>
            &nbsp;<div>
            </div>
        </div>

        <div>
            <asp:Button ID="btnAgregar" runat="server" CssClass="btn-info" Text="Agregar" OnClick="btnAgregar_Click" />
            <br />
            <br />
            <asp:GridView BorderStyle="None" CssClass="table" GridLines="Horizontal"  ID="grdUsuarios" runat="server" AllowPaging="True" AutoGenerateColumns="False" PageSize="5" OnLoad="grdUsuarios_Load" OnPageIndexChanged="grdUsuarios_PageIndexChanged" OnRowCommand="grdUsuarios_RowCommand"  >
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Id" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellidoPaterno" HeaderText="Primer Apellido" />
                    <asp:BoundField DataField="apellidoMaterno" HeaderText="Segundo apellido" />
<%--                    <asp:BoundField DataField="fechaNacimiento" HeaderText="Fecha nacimiento" />
                    <asp:BoundField DataField="correo" HeaderText="Correo" />
                    <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                    <asp:BoundField DataField="contrasena" HeaderText="Contraseña" />--%>
                    <asp:ButtonField CommandName="CommandEdit" Text="Editar">
                    <ControlStyle CssClass="btn btn-warning" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="CommandDel" Text="Eliminar">
                    <ControlStyle CssClass="btn btn-danger" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="CommandSel" Text="Consultar">
                    <ControlStyle CssClass="btn btn-success" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </div>
    </div>

    </div>


</asp:Content>
