<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion.Usuarios.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <form id="form1" >
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContra" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                
            </tr>
            
        </table>
    <div>
    
    </div>
    </form>



</asp:Content>
