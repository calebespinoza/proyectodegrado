<%@ Page Title="" Language="C#" MasterPageFile="~/MPStudent.Master" AutoEventWireup="true" CodeBehind="CalificacionesEstudiante.aspx.cs" Inherits="QualificationsWebSystem.CalificacionesEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
        }
        .style5
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
    <br />
    <asp:Label ID="lbl_Estudiante" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: 700"></asp:Label>
    <span class="style5"><strong><br />
    </strong>Módulo: Arquitectura y Modelos de Seguridad<br />
    <br />
    </span>
    <asp:Label ID="Label5" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif" Text="Seleccione un Módulo:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
        <asp:ListItem>Arquitectura y Modelos de Seguridad</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" 
        style="font-size: small; font-weight: 700" 
        Text="La escala de calificación oscila entre 10 y 100 puntos"></asp:Label>
    <br />
    <br />
<br />
    <asp:Label ID="Label4" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="CALIFICACIONES DE PRUEBAS PARCIALES"></asp:Label>
<br />
<br />
    <asp:Label ID="Label11" runat="server" 
        style="font-size: small; font-family: Arial, Helvetica, sans-serif" 
        Text="Ver resultado total de la tabla en Calificación Parcial."></asp:Label>
<asp:GridView ID="GridView1" runat="server" 
    onselectedindexchanged="GridView1_SelectedIndexChanged" Height="89px" 
        style="margin-left: 357px" Width="615px" BackColor="White" 
        BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
        ForeColor="Black" GridLines="Vertical">
    <AlternatingRowStyle BackColor="White" />
    <FooterStyle BackColor="#CCCC99" />
    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
    <RowStyle BackColor="#F7F7DE" />
    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FBFBF2" />
    <SortedAscendingHeaderStyle BackColor="#848384" />
    <SortedDescendingCellStyle BackColor="#EAEAD3" />
    <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>
    <asp:Label ID="Label9" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-size: small; text-align: left" 
        Text="*Ponderación = Es el porcentaje de ponderación definido por el docente del módulo." 
        Width="600px"></asp:Label>
    <br />
<br />
<br />
<br />
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="CALIFICACIONES TOTALES"></asp:Label>
<br />
    <asp:Label ID="Label7" runat="server" 
        style="font-weight: 700; font-size: small" 
        Text="La calificación mínima de aprobación es 61 puntos"></asp:Label>
    <br />
<br />
    <asp:GridView ID="GridView2" runat="server" BackColor="White" 
        BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
        ForeColor="Black" GridLines="Vertical" style="margin-left: 357px" Width="616px">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <asp:Label ID="Label8" runat="server" 
        style="text-align: left; font-size: small; font-family: Arial, Helvetica, sans-serif" 
        Text="Calificación Parcial = Equivale al 60% de la Calificación Total" 
        Width="600px"></asp:Label>
<br />
    <asp:Label ID="Label10" runat="server" 
        style="text-align: left; font-size: small; font-family: Arial, Helvetica, sans-serif" 
        Text="Calificación Final = Equivale al 40% de la Calificación Total" 
        Width="600px"></asp:Label>
<br />
<br />
<br />
<br />
<br />
</asp:Content>
