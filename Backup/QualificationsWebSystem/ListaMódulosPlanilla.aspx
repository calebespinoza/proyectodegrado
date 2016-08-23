<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="ListaMódulosPlanilla.aspx.cs" Inherits="QualificationsWebSystem.ListaMódulosPlanilla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<asp:Label ID="Label3" runat="server" 
    style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
    Text="LISTA DE MODULOS PARA PLANILLA GENERAL"></asp:Label>
<br />
<br />
<br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
    GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged" 
    style="margin-left: 390px" Width="561px">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:HyperLinkField DataNavigateUrlFields="Módulo,Programa,Versión" 
            DataNavigateUrlFormatString="Planilla General.aspx?ModuleName={0}&amp;ProgramName={1}&amp;ID={2}" 
            NavigateUrl="~/Planilla General.aspx" Text="Seleccionar Módulo" />
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
<br />
<br />
</asp:Content>
