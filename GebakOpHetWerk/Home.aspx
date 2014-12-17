<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
    <table style="width: 100%;">
        <tr>
            <td>Voornaam:</td>
            <td>
                <asp:Label ID="lblVoornaam" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Achternaam:</td>
            <td>
                <asp:Label ID="lblAchternaam" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Tussenvoegsels:</td>
            <td>
                <asp:Label ID="lblTussen" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Email:</td>
            <td>
                <asp:Label ID="lblEmail" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Adres:</td>
            <td>
                <asp:Label ID="lblAdres" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>plaats:</td>
            <td>
                <asp:Label ID="lblPlaats" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Postcode:</td>
            <td>
                <asp:Label ID="lblPostcode" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnedit" runat="server" Text="Aanpassen" OnClick="btnedit_Click" /></td>
        </tr>
    </table>
        </ContentTemplate></asp:UpdatePanel>
</asp:Content>

