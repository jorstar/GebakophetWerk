<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="GebakOpHetWerk.User_Controls.Login" %>
<table style="width: 100%;">
    <tr>
        <td>Login:</td>
    </tr>
    <tr>
        <td>Gebruikersnaam:</td>
        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Wachtwoord</td>
        <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Geen Account? <asp:HyperLink ID="HyperLink1" runat="server">Registreren</asp:HyperLink></td>
        <td><asp:Button ID="Button1" runat="server" Text="Button" /></td>
    </tr>
</table>

