<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaDocenteModulo.aspx.cs" Inherits="QualificationsWebSystem.ListaDocenteModulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="LISTA DE DOCENTES ASIGNADOS A LOS MÓDULOS RESPECTIVOS"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="font-size: small; font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FFFFFF; text-align: left" 
        Text="Escriba el nombre del Módulo:" Width="720px"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="BUSCAR" Width="200px" 
        onclick="Button1_Click" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="LISTA GENERAL" Width="200px" 
        onclick="Button2_Click" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" style="margin-left: 126px" Width="1038px" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
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
