<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeFile="AllUsers.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    Alle klanten:
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="usersds" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
            <asp:BoundField DataField="Middlename" HeaderText="Middlename" SortExpression="Middlename" />
            <asp:BoundField DataField="Lastname" HeaderText="Lastname" SortExpression="Lastname" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Adress" HeaderText="Adress" SortExpression="Adress" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="Zipcode" HeaderText="Zipcode" SortExpression="Zipcode" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:CheckBoxField DataField="Rights" HeaderText="Rights" SortExpression="Rights" />
            <asp:CheckBoxField DataField="Activated" HeaderText="Activated" SortExpression="Activated" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
        </Columns>
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
    <asp:SqlDataSource ID="usersds" runat="server" ConnectionString="<%$ ConnectionStrings:GebakophetWerkConnectionString %>" SelectCommand="SELECT [Firstname], [Middlename], [Lastname], [Email], [Adress], [City], [Zipcode], [Username], [Rights], [Activated], [ID] FROM [User]"></asp:SqlDataSource>
    <br />
    <asp:DropDownList ID="ddlGebruiker" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="179px">
    </asp:DropDownList>
&nbsp;<asp:Button ID="btnDeactiveer" runat="server" OnClick="btnDeactiveer_Click" Text="deactiveer gebruiker" />
    <asp:Button ID="btnActiveer" runat="server" OnClick="btnActiveer_Click" Text="activeer gebruiker" Width="167px" />
</asp:Content>

