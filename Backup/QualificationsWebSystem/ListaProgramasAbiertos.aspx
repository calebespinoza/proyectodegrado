<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaProgramasAbiertos.aspx.cs" Inherits="QualificationsWebSystem.ListaProgramasAbiertos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <br />
    <asp:Label ID="Label3" runat="server" Text="LISTA DE PROGRAMAS ABIERTOS" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large; color: #FFFFFF"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged" 
        style="margin-left: 105px" Width="1075px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField Text="Modificar" 
                DataNavigateUrlFields="ProgramaPostgrado,Versión" 
                DataNavigateUrlFormatString="ModificarApertura.aspx?ProgramName={0}&amp;ProgramVersion={1}" 
                NavigateUrl="~/ModificarApertura.aspx" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
