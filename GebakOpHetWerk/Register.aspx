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
                <td>Voornaam</td>
                <td>
                    <asp:TextBox ID="tbFirstname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Achternaam</td>
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
                <td>Adres</td>
                <td>
                    <asp:TextBox ID="tbAdress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Postcode
                    <asp:RegularExpressionValidator ID="regexZipcode" runat="server" ErrorMessage="Postcode is Incorrect" ValidationExpression="^[1-9][0-9]{3}\s?[a-zA-Z]{2}$" ControlToValidate="tbZipcode" Text="*" />
                </td>
                <td>
                    <input id="tbZipcode" title="Postcode" pattern="^[1-9][0-9]{3}\s?[a-zA-Z]{2}$" type="text" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Plaats</td>
                <td>
                    <asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email
                    <asp:RegularExpressionValidator ID="RegexEmail" runat="server" ErrorMessage="Postcode is Incorrect" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" ControlToValidate="tbEmail" Text="*" />
                </td>
                <td>
                    <input id="tbEmail" title="Email" type="text" pattern="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Gebruikersnaam</td>
                <td>
                    <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Wachtwoord</td>
                <td>
                    <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Registreren" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

