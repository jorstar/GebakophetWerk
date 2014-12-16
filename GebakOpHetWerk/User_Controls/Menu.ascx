<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="User_Controls_WebUserControl" %>
<div id="nav">
    <asp:Menu ID="HoofdMenu" runat="server" Orientation="Horizontal" StaticEnableDefaultPopOutImage="False" EnableViewState="False">
        <Items>
            <asp:MenuItem Text="Home" Value="Home" NavigateUrl="../home.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Taarten" Value="Taarten" Selectable="False">
                <asp:MenuItem NavigateUrl="../AllCakes.aspx" Text="Assortiment" Value="Assortiment"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="../PlaceOrder.aspx" Text="Bestellen" Value="Bestellen"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Mijn Bestellingen" Value="myorders" NavigateUrl="../Myorders.aspx"></asp:MenuItem>
            <asp:MenuItem Selectable="False" Text="Administratie" Value="Admin">
                <asp:MenuItem NavigateUrl="../AddPie.aspx" Text="Taart Toevoegen" Value="Addpie"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="../AllOrders.aspx" Text="Alle Bestellingen" Value="Orders"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="../BakePies.aspx" Text="Te Bakken Taarten" Value="BakePies"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="../AllUsers.aspx" Text="Alle Gebruikers" Value="allusers"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem NavigateUrl="../Register.aspx" Text="Registreren" Value="Register"></asp:MenuItem>
            <asp:MenuItem Text="Inloggen" Value="Login" NavigateUrl="../Login.aspx"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="../Logout.aspx" Text="Uitloggen" Value="loguit"></asp:MenuItem>
        </Items>
    </asp:Menu>
</div>