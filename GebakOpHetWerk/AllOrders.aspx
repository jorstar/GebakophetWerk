<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeFile="AllOrders.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <p>
        Alle Bestellingen:</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnPrint" runat="server" Text="print dit uit" OnClick="btnPrint_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFactuur" runat="server" Text="print de facturen" OnClick="btnFactuur_Click" />
    </p>
</asp:Content>

