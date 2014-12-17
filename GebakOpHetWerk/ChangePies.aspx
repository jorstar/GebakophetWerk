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
            <td>Taart naam:<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbPiename" ErrorMessage="Taartnaam moet ingevult worden." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="tbPiename" runat="server" /></td>
        </tr>
        <tr>
            <td>Taart Prijs:<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPrice" ErrorMessage="Prijs moet ingevult worden." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbPrice" ErrorMessage="De prijs moet een nummer zijn." ForeColor="Red" ValidationGroup="1">*</asp:RegularExpressionValidator>
            </td>
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
            <td>Omschrijving:<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbDescription" ErrorMessage="Vul een omschrijving in." ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
            <td><asp:TextBox ID="tbDescription" runat="server" Rows="5" TextMode="MultiLine" /></td>
        </tr>
        <tr>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="1" />
            </td>
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

