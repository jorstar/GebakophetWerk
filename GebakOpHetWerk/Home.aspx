<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
    <table style="width: 100%;">
        <tr>
            <td>Voornaam:</td>
            <td>
                <asp:TextBox ID="tbvoornaam" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Achternaam:</td>
            <td><asp:TextBox ID="tbachternaam" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tussenvoegsels:</td>
            <td><asp:TextBox ID="tbtussen" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="tbemail" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Adres:</td>
            <td><asp:TextBox ID="tbadres" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>plaats:</td>
            <td><asp:TextBox ID="tbplaats" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Postcode:</td>
            <td><asp:TextBox ID="tbpostcode" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Wachtwoord:</td>
            <td><asp:TextBox ID="tbwachtwoord" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSave" runat="server" Enabled="false" Text="Opslaan" OnClick="btnSave_Click" /></td>
            <td>
                <asp:Button ID="btnedit" runat="server" Text="Aanpassen" OnClick="btnedit_Click" /><asp:Button ID="btncancel" Enabled="false" runat="server" Text="Annuleren" OnClick="btncancel_Click" /></td>
        </tr>
    </table>
        </ContentTemplate></asp:UpdatePanel>
</asp:Content>

