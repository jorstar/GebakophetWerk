<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
    <table style="width: 100%;">
        <tr>
            <td>Voornaam:<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbvoornaam" /></td>
            <td>
                <asp:TextBox ID="tbvoornaam" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Achternaam:<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbachternaam" /></td>
            <td><asp:TextBox ID="tbachternaam" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tussenvoegsels:</td>
            <td><asp:TextBox ID="tbtussen" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email:<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbemail" /></td>
            <td><asp:TextBox ID="tbemail" ReadOnly="true" runat="server" pattern="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" TextMode="Email"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Adres:<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbadres" /></td>
            <td><asp:TextBox ID="tbadres" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>plaats:<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbplaats" /></td>
            <td><asp:TextBox ID="tbplaats" ReadOnly="true" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Postcode:<asp:RequiredFieldValidator ID="RequiredFieldValidator6" pattern="^[1-9][0-9]{3}\s?[a-zA-Z]{2}$" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbpostcode" /></td>
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

