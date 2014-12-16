<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <div id="register">
        <table>
            <tr>
                <td>Registreren:</td>
            </tr>
            <tr>
                <td >Voornaam<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbFirstname" ErrorMessage="Voornaam is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td >
                    <asp:TextBox ID="tbFirstname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Achternaam<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbLastname" ErrorMessage="Achternaam is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="tbLastname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tussenvoegsels</td>
                <td>
                    <asp:TextBox ID="tbMiddelname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Adres<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbAdress" ErrorMessage="Adres is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="tbAdress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Postcode
                    <asp:RegularExpressionValidator ID="regexZipcode" runat="server" ErrorMessage="Postcode is Incorrect" ValidationExpression="^[1-9][0-9]{3}\s?[a-zA-Z]{2}$" ControlToValidate="tbZipcode" Text="*" ForeColor="Red" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbZipcode" ErrorMessage="Voornaam is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <input id="tbZipcode" title="Postcode" pattern="^[1-9][0-9]{3}\s?[a-zA-Z]{2}$" type="text" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Plaats<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbCity" ErrorMessage="Plaats is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email
                    <asp:RegularExpressionValidator ID="RegexEmail" runat="server" ErrorMessage="Postcode is Incorrect" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" ControlToValidate="tbEmail" Text="*" ForeColor="Red" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <input id="tbEmail" title="Email" type="text" pattern="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Gebruikersnaam<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbUsername" ErrorMessage="Gebruikersnaam is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Wachtwoord<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="tbPassword" ErrorMessage="Wachtwoord is verplicht." ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Registreren" OnClick="btnRegister_Click" />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
</asp:Content>

