<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="ChangeUser.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <table>
        <tr>
            <td>Email:<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbemail" /></td>
            <td><asp:TextBox ID="tbemail" runat="server" pattern="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" TextMode="Email" EnableViewState="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Adres:<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbadres" /></td>
            <td><asp:TextBox ID="tbadres" runat="server" EnableViewState="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td>plaats:<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbplaats" /></td>
            <td><asp:TextBox ID="tbplaats" runat="server" EnableViewState="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Postcode:<asp:RequiredFieldValidator ID="RequiredFieldValidator6" pattern="^[1-9][0-9]{3}\s?[a-zA-Z]{2}$" runat="server" ErrorMessage="Voornaam is verplicht." Text="*" ControlToValidate="tbpostcode" /></td>
            <td><asp:TextBox ID="tbpostcode" runat="server" EnableViewState="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Wachtwoord:</td>
            <td><asp:TextBox ID="tbwachtwoord" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSave" runat="server" Text="Opslaan" OnClick="btnSave_Click" /></td>
            <td>
                <asp:Button ID="btncancel" runat="server" Text="Annuleren" OnClick="btncancel_Click" /></td>
        </tr>
    </table>
</asp:Content>

