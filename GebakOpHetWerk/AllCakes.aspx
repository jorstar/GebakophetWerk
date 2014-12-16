<%@ Page Title="" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="AllCakes.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:ListView ID="ListView1" runat="server" DataSourceID="allpiesDS" DataKeyNames="ID">
       <AlternatingItemTemplate>
            <div class="pielistalter">
                <table>
                    <tr>
                        <td></td>
                        <td><h3><asp:Label ID="lblPie" runat="server" Text='<%# Eval("Name") %>' /></h3></td>
                    </tr>
                    <tr>
                        <td><asp:Image ID="imgPie" ImageUrl='<%# Eval("Picture") %>' runat="server" /></td>
                        <td><asp:Label ID="lbldescPie" runat="server" Text='<%# Eval("Description") %>' /></td>
                        <td><asp:Label ID="Label1" runat="server" Text='<%# Eval("Price") %>' /></td>
                    </tr>
                </table>
            </div>
            <br />
        </AlternatingItemTemplate>
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
        <ItemTemplate>
            <div class="pielist">
                <table>
                    <tr>
                        <td></td>
                        <td><h3><asp:Label ID="lblPie" runat="server" Text='<%# Eval("Name") %>' /></h3></td>
                    </tr>
                    <tr>
                        <td><asp:Image ID="imgPie" ImageUrl='<%# Eval("Picture") %>' runat="server" /></td>
                        <td><asp:Label ID="lbldescPie" runat="server" Text='<%# Eval("Description") %>' /></td>
                        <td><asp:Label ID="Label1" runat="server" Text='<%# Eval("Price") %>' /></td>
                    </tr>
                </table>
            </div>
            <br />
        </ItemTemplate>
        <LayoutTemplate>
            <div style="font-family: Verdana, Arial, Helvetica, sans-serif;" id="itemPlaceholderContainer" runat="server">
                <span runat="server" id="itemPlaceholder" />
            </div>
            <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
    </asp:ListView>
    
    <asp:SqlDataSource ID="allpiesDS" runat="server" ConnectionString="<%$ ConnectionStrings:GebakophetWerkConnectionString %>" SelectCommand="SELECT [ID], [Name], [Description], [Picture], [Price] FROM [Pie] WHERE ([Activated] = @Activated) ORDER BY [Name]">
        <SelectParameters>
            <asp:Parameter DefaultValue="True" Name="Activated" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
    
</asp:Content>

