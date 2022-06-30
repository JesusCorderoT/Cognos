<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Usuarios.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="form-horizontal">
        <h2>Consulta Usuario</h2>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                <asp:Label ID="Label" runat="server" Text="ID"></asp:Label>
            </dt>
            <dd>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <asp:Label ID="Label3" runat="server" Text="Primer apellido"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblPa" runat="server" Text=" "></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label4" runat="server" Text="Segundo apellido"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblSp" runat="server" Text=" "></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblFn" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <asp:Label ID="Label7" runat="server" Text="Correo"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label>
            </dd>


             <dt>
                <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
            </dd>

              <dt>
                <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblContra" runat="server" Text=""></asp:Label>
            </dd>



        </dl>

</asp:Content>
