<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:Button ID="btnlogout" runat="server" Text="Uitloggen" OnClick="btnlogout_Click" /><asp:Button ID="btnCancel" runat="server" Text="Annuleren" OnClick="btnCancel_Click" />
</asp:Content>

