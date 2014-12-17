<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeFile="PlaceOrder.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            
    Taarten:
    <asp:DropDownList ID="ddlTaarten" runat="server" OnSelectedIndexChanged="ddlTaarten_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <br />
    Aantal:&nbsp;
    <asp:TextBox ID="tbAantal" runat="server" Width="34px" min="0" OnTextChanged="tbAantal_TextChanged" TextMode="Number"></asp:TextBox>
            <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnToevoegen" runat="server" Text="Bestellen" OnClick="btnToevoegen_Click" />
    <br />
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

