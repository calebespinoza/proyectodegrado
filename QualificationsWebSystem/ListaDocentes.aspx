<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaDocentes.aspx.cs" Inherits="QualificationsWebSystem.ListaDocentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
<br />
<br />
<asp:Label ID="Label3" runat="server" 
    style="font-weight: 700; font-size: large; color: #FFFFFF" 
    Text="LISTA DE DOCENTES REGISTRADOS"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" 
        style="text-align: left; color: #FFFFFF; font-weight: 700" 
        Text="Nombre o Apellido:" Width="540px"></asp:Label>
<br />
    <asp:TextBox ID="txt_CI" runat="server" Height="23px" Width="200px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Height="30px" onclick="Button1_Click" 
        style="font-weight: 700" Text="Buscar Docente" Width="150px" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Height="30px" onclick="Button2_Click" 
        style="font-weight: 700" Text="Lista General" Width="150px" />
<br />
<br />
<br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
    GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:HyperLinkField Text="Modificar" 
            DataNavigateUrlFields="Nombre,Paterno,Materno,CI" 
            DataNavigateUrlFormatString="ModificarUsuarioAcademico.aspx?Name={0}&amp;FirstName={1}&amp;LastName={2}&amp;IdentityCard={3}" 
            NavigateUrl="~/ModificarUsuarioAcademico.aspx" />
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
