<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaInscripciones.aspx.cs" Inherits="QualificationsWebSystem.ListaInscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="LISTA DE INSCRIPCIONES"></asp:Label>
</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="color: #FFFFFF; font-size: small; font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left" 
        Text="Escriba el nombre o apellido del Estudiante:" Width="710px"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
&nbsp;
    <asp:Button ID="Button1" runat="server" style="font-weight: 700" 
        Text="BUSCAR ESTUDIANTE" Width="200px" onclick="Button1_Click" />
&nbsp;
    <asp:Button ID="Button2" runat="server" style="font-weight: 700" 
        Text="LISTA GENERAL" Width="200px" onclick="Button2_Click" />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged" 
        Width="1246px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Nombre,Paterno,Materno,Módulo,Programa,Versión" 
                DataNavigateUrlFormatString="EliminarInscripción.aspx?Name={0}&amp;FirstName={1}&amp;LastName={2}&amp;ModuleName={3}&amp;ProgramName={4}&amp;Version={5}" 
                NavigateUrl="~/EliminarInscripción.aspx" Text="Eliminar Inscripción" />
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
