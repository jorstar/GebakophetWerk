<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="AddPie.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <table style="width: 100%;">
        <tr>
            <td>Taart Toevoegen:</td>
        </tr>
        <tr>
            <td>Taart naam:<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbPiename" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="tbPiename" runat="server" /></td>
        </tr>
        <tr>
            <td>Taart Prijs:<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPrice" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbPrice" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationGroup="1">*</asp:RegularExpressionValidator>
            </td>
            <td><asp:TextBox ID="tbPrice" runat="server" /></td>
        </tr>
        <tr>
            <td>Afbeelding:</td>
            <td>
                <asp:FileUpload ID="fuPicture" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Omschrijving:<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbDescription" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            </td>
            <td><asp:TextBox ID="tbDescription" runat="server" Rows="5" TextMode="MultiLine" /></td>
        </tr>
        <tr>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="1" />
            </td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Opslaan" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

