<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="GebakOpHetWerk.User_Controls.Menu" %>
<div id="nav">
    <asp:Menu ID="mainmenu" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
            <asp:MenuItem Text="Taarten" Value="Taarten"></asp:MenuItem>
            <asp:MenuItem Text="Account" Value="Account"></asp:MenuItem>
            <asp:MenuItem></asp:MenuItem>
        </Items>
    </asp:Menu>
</div>
