<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="AddPie.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <table style="width: 100%;">
        <tr>
            <td>Taart Toevoegen:</td>
        </tr>
        <tr>
            <td>Taart naam:</td>
            <td>
                <asp:TextBox ID="tbPiename" runat="server" /></td>
        </tr>
        <tr>
            <td>Taart Prijs:</td>
            <td><asp:TextBox ID="tbPrice" runat="server" /></td>
        </tr>
        <tr>
            <td>Afbeelding:</td>
            <td>
                <asp:FileUpload ID="fuPicture" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Omschrijving:</td>
            <td><asp:TextBox ID="tbDescription" runat="server" Rows="5" TextMode="MultiLine" /></td>
        </tr>
    </table>
</asp:Content>

