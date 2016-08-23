<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaModulosPorPrograma.aspx.cs" Inherits="QualificationsWebSystem.RegistrarModuloPrograma" %>
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
        Text="LISTA DE MÓDULOS POR PROGRAMA DE POSTGRADO"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="font-size: small; font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left;" 
        Text="Seleccione un Programa de Postgrado:" Width="530px"></asp:Label>
    <br />
    <asp:DropDownList ID="ddl_Programas" runat="server" Width="300px" 
        onselectedindexchanged="ddl_Programas_SelectedIndexChanged" 
        style="font-family: Arial, Helvetica, sans-serif" 
        DataSourceID="SqlDataSource1" DataTextField="ProgramName" 
        DataValueField="ProgramName">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:QualificationsDBConnectionString %>" 
        
        SelectCommand="SELECT [ProgramName] FROM [GraduateProgram] ORDER BY [ProgramName]">
    </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="font-weight: 700" Text="GENERAR LISTA" Height="25px" 
        Width="200px" />
</p>
<p>
    <br />
</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" style="margin-left: 335px; margin-right: 0px" Width="653px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:HyperLinkField Text="Modificar" DataNavigateUrlFields="Modulo" 
                    DataNavigateUrlFormatString="ModificarModulo.aspx?ModuleName={0}" 
                    NavigateUrl="~/ModificarModulo.aspx" ShowHeader="False" />
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
</p>
    <p>
</p>
<p>
</p>
</asp:Content>
