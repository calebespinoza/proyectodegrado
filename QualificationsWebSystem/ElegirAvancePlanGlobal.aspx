<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="ElegirAvancePlanGlobal.aspx.cs" Inherits="QualificationsWebSystem.RegistrarAvance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" style="font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-size: large;" 
        Text="REGISTRAR AVANCE DE CONTENIDO"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="Seleccione un Módulo:"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" Width="855px" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" style="margin-left: 201px; margin-right: 0px">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Módulo,Programa,Versión" 
                DataNavigateUrlFormatString="RegistrarAvanceContenido.aspx?ModuleName={0}&amp;ProgramName={1}&amp;ID={2}" 
                NavigateUrl="~/RegistrarAvanceContenido.aspx" Text="Seleccionar" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
