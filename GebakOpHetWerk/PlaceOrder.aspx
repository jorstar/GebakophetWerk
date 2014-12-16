<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeFile="PlaceOrder.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            
    Taarten:
    <asp:DropDownList ID="ddlTaarten" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    Aantal:&nbsp;
    <asp:TextBox ID="tbAantal" runat="server" Width="34px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnToevoegen" runat="server" Text="toevoegen" OnClick="btnToevoegen_Click" />
    <br />
    <br />
            <asp:GridView ID="GridViewBestelling" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
    <br />
    <asp:Button ID="btnBestellen" runat="server" OnClick="btnBestellen_Click" Text="bestel" />
    <br />
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

