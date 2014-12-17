<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeFile="ChangePies.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <p>
        de taarten:
        <asp:DropDownList ID="ddlTaarten" runat="server" Height="20px" Width="172px" AutoPostBack="True" OnSelectedIndexChanged="ddlTaarten_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;&nbsp;
        <asp:Button ID="btnDeactiveer" runat="server" OnClick="btnDeactiveer_Click" Text="deactiveer taart" />
    </p>
    <table style="width: 100%;">
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
            <td class="auto-style1">Afbeelding:</td>
            <td class="auto-style1">
                <asp:TextBox ID="tbAfbeelding" runat="server" Width="203px"></asp:TextBox>
                <asp:FileUpload ID="fuPicture" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Omschrijving:</td>
            <td><asp:TextBox ID="tbDescription" runat="server" Rows="5" TextMode="MultiLine" /></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnAanpassen" runat="server" OnClick="btnAanpassen_Click" Text="aanpassen" />
&nbsp;
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Annuleren" />
&nbsp;
                <asp:Button ID="btnSave" runat="server" Text="Opslaan" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

