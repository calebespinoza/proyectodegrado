<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaMódulos.aspx.cs" Inherits="QualificationsWebSystem.ListaMódulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" style="font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-size: large;" 
        Text="LISTA DE MÓDULOS"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" 
        style="font-weight: 700; font-size: small; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Escriba el Módulo:" Width="630px"></asp:Label>
    <br />
    <asp:TextBox ID="txt_criterio" runat="server" Width="300px"></asp:TextBox>
&nbsp;
    <asp:Button ID="Button1" runat="server" Height="25px" style="font-weight: 700" 
        Text="Buscar Módulo" Width="150px" onclick="Button1_Click" />
&nbsp;
    <asp:Button ID="Button2" runat="server" Height="25px" onclick="Button2_Click" 
        style="font-weight: 700" Text="Lista General" Width="150px" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged" 
        Width="744px" style="margin-left: 305px; margin-right: 0px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField Text="Modificar datos" DataNavigateUrlFields="Modulo" 
                DataNavigateUrlFormatString="ModificarModulo.aspx?ModuleName={0}" 
                NavigateUrl="~/ModificarModulo.aspx" />
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
    <br />
    <br />
</asp:Content>
