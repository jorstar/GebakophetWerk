<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="User_Controls_Login" %>
<div id="login">
    <table>
        <tr>
            <td>Login:</td>
        </tr>
        <tr>
            <td>Gerbuikersnaam:
            </td>
            <td>
                <asp:TextBox ID="tbUsername" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Wachtwoord:
            </td>
            <td>
                <asp:TextBox ID="tbPassword" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Geen account?
                <asp:HyperLink ID="HLRegister" NavigateUrl="../Register.aspx" runat="server">Registreren.</asp:HyperLink>
            </td>
        </tr>
    </table>
</div>
