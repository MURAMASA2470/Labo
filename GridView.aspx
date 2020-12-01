<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label runat="server" Text="部門" />
    <asp:DropDownList ID="DropDown" runat="server" OnSelectedIndexChanged="DropDown_SelectedIndexChanged" />

    <asp:GridView ID="GridList" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>年月</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "DATE")%>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>部門コード</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "BMCD")%>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>発注先名</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "ORNM")%>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
