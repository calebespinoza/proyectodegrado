<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaEstudiantes.aspx.cs" Inherits="QualificationsWebSystem.ListaEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
<br />
<asp:Label ID="Label3" runat="server" 
    style="font-size: large; font-weight: 700; color: #FFFFFF" 
    Text="LISTA DE ESTUDIANTES REGISTRADOS"></asp:Label>
<br />
<br />
<br />
<br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
    GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:HyperLinkField Text="Inscribir" DataNavigateUrlFields="Nombre,CI" 
            DataNavigateUrlFormatString="RegistrarInscripción.aspx?Name={0}&amp;IdentityCard={1}" 
            NavigateUrl="~/RegistrarInscripción.aspx" ShowHeader="False" />
        <asp:HyperLinkField DataNavigateUrlFields="Nombre,Paterno,Materno,CI" 
            DataNavigateUrlFormatString="ModificarUsuarioAcademico.aspx?Name={0}&amp;FirstName={1}&amp;LastName={2}&amp;IdentityCard={3}" 
            NavigateUrl="~/ModificarUsuarioAcademico.aspx" Text="Modificar Datos" />
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
</asp:Content>
