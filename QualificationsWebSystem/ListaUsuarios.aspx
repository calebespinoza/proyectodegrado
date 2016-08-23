<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="QualificationsWebSystem.ListaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style7
        {
            color: #FFFFFF;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style8
        {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
<asp:Label ID="Label3" runat="server" style="font-weight: 700; color: #FFFFFF; font-size: large; font-family: Arial, Helvetica, sans-serif;" 
    Text="LISTA DE USUARIOS REGISTRADOS"></asp:Label>
<br />
    <br />
    <br />
    <span class="style7"><strong>USUARIOS ADMINISTRATIVOS</strong></span><br />
    <br />
    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" onselectedindexchanged="GridView2_SelectedIndexChanged" 
        Width="1275px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:HyperLinkField NavigateUrl="~/ModificarUsuario.aspx" ShowHeader="False" 
                Text="Modificar" DataNavigateUrlFields="Cuenta,Password" 
                DataNavigateUrlFormatString="ModificarUsuario.aspx?Account={0}&amp;Password={1}" />
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
    <br class="style8" />
    <span class="style7"><strong>USUARIOS ACADÉMICOS<br />
    <br />
    </strong></span>
    <asp:Label ID="Label5" runat="server" 
        style="color: #FFFFFF; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: small" 
        Text="Para una búsqueda específica seleccione a un tipo de Usuario Académico:" 
        Width="632px"></asp:Label>
    <strong>
    <asp:RadioButtonList ID="rbl_TipoUsuario" runat="server" Height="26px" 
        RepeatDirection="Horizontal" 
        style="text-align: left; color: #FFFFFF; margin-left: 376px" Width="258px">
        <asp:ListItem>Docente</asp:ListItem>
        <asp:ListItem>Estudiante</asp:ListItem>
    </asp:RadioButtonList>
    </strong>
    <br />
    <asp:Label ID="Label4" runat="server" 
        style="color: #FFFFFF; text-align: left; font-family: Arial, Helvetica, sans-serif; font-size: small; margin-left: 0px" 
        Text="Nombre, Apellido o Cuenta del Usuario (solo un dato):" Width="635px"></asp:Label>
    <br />
    <asp:TextBox ID="txt_Criterio" runat="server" Height="23px" Width="325px"></asp:TextBox>
&nbsp;
    <asp:Button ID="btn_Buscar" runat="server" Height="27px" 
        onclick="btn_Buscar_Click" style="font-weight: 700" Text="Buscar Usuario" 
        Width="150px" />
&nbsp;
    <asp:Button ID="btn_General" runat="server" Height="27px" 
        onclick="btn_General_Click" style="font-weight: 700" Text="Lista General" 
        Width="150px" />
    <br />
    <br />
    <br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" onselectedindexchanged="GridView1_SelectedIndexChanged" 
    style="margin-top: 0px; margin-left: 2px;" Width="1275px" ForeColor="#333333" 
        GridLines="None">
    <RowStyle BackColor="#EFF3FB" />
    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
    <br />
    <br />
    <br />
<br />
    <br />
</asp:Content>
