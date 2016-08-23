<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaProgramaPost.aspx.cs" Inherits="QualificationsWebSystem.ListaProgramaPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label3" runat="server" style="font-weight: 700; color: #FFFFFF; font-size: large; font-family: Arial, Helvetica, sans-serif;" 
            Text="LISTA DE PROGRAMAS DE POSTGRADO"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" Height="198px" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" Width="1274px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="NombrePrograma" 
                    DataNavigateUrlFormatString="ModificarProgramaPostgrado.aspx?ProgramName={0}" 
                    NavigateUrl="~/ModificarProgramaPostgrado.aspx" Text="Modificar" />
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
    <p>
        &nbsp;</p>
</asp:Content>
