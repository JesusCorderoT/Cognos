<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Usuarios.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <div class="form-horizontal">
        <h2>Editar Usuario</h2>
        <hr />


        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label" runat="server" Text="Id"></asp:Label>
            <asp:TextBox Class="form-control text-box single-line" ID="txtId" runat="server" Enabled="false"></asp:TextBox>
            <div>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox Class="form-control text-box single-line" ID="txtNombre" runat="server" EnableTheming="True"></asp:TextBox>
            <div style="font-weight: 700">
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label3" runat="server" Text="Primer apellido"></asp:Label>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Solo letras y espacios" ValidationExpression="^[a-zA-Z](\s*[a-zA-Z]*)*[a-zA-Z]+$"></asp:RegularExpressionValidator>
                <asp:TextBox Class="form-control text-box single-line" ID="txtPa" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label4" runat="server" Text="Segundo apellido"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtSp" runat="server"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtFn" runat="server" type="DateTime" TextMode="Date" ClientIDMode="Static"></asp:TextBox>
            </div>
        </div>

               <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label7" runat="server" Text="Correo"></asp:Label>
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
                <asp:Button Class="btn btn-warning" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Guardar" />
            </div>
        </div>

        <div class="form-group">
             <div class="col-md-2">
                <a  href="Index.aspx">Regresar a la lista</a>
            </div>
        </div>


    </div>





</asp:Content>
