<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Usuarios.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div class="form-horizontal">
        <h2>Crear Usuario</h2>
        <hr />


        <div class="form-group">
            <div>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" CssClass="alert-danger" ErrorMessage="Nombre obligatorio"></asp:RequiredFieldValidator>
            <asp:TextBox Class="form-control text-box single-line" ID="txtNombre" runat="server" EnableTheming="True"></asp:TextBox>
            <div style="font-weight: 700">
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label3" runat="server" Text="Primer apellido"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvPa" runat="server" ControlToValidate="txtPa" CssClass="alert-danger" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
                <asp:TextBox Class="form-control text-box single-line" ID="txtPa" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label4" runat="server" Text="Segundo apellido"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSp" CssClass="alert-danger" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
                <asp:TextBox Class="form-control text-box single-line" ID="txtSp" runat="server"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFn" CssClass="alert-danger" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
                <asp:TextBox Class="form-control text-box single-line" ID="txtFn" runat="server" type="DateTime" TextMode="Date" ClientIDMode="Static"></asp:TextBox>
            </div>
        </div>

               <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label7" runat="server" Text="Correo"></asp:Label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCorreo" CssClass="alert-danger" ErrorMessage="Formato incorrecto" ValidationExpression="^[^@]+@[^@]+\.[a-zA-Z]{2,}$"></asp:RegularExpressionValidator>
                <asp:TextBox Class="form-control text-box single-line" ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label6" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtUsuario" runat="server" ClientIDMode="Static"></asp:TextBox>
            </div>
        </div>

              <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label1" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtContra" runat="server" ClientIDMode="Static"></asp:TextBox>
            </div>
        </div>


             <div class="form-group">
            <div class="col-md-2">
                <asp:Button class="btn btn-success" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                <br />
            </div>
        </div>



        </div>
</asp:Content>
