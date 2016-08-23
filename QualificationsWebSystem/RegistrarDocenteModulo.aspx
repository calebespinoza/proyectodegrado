<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="RegistrarDocenteModulo.aspx.cs" Inherits="QualificationsWebSystem.RegistrarDocenteModulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; color: #FFFFFF; font-size: large; font-family: Arial, Helvetica, sans-serif" 
        Text="ASIGNAR DOCENTE A MÓDULOS"></asp:Label>
</p>
<p>
    &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" 
        onclick="LinkButton2_Click" Visible="False">Regresar a la página anterior</asp:LinkButton>
</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="font-weight: 700; font-size: small; color: #FFFFFF; text-align: left; font-family: Arial, Helvetica, sans-serif;" 
        Text="Seleccione un Programa de Postgrado:" Width="300px"></asp:Label>
    <br />
</p>
<p>
    <asp:DropDownList ID="ddl_Programas" runat="server" 
        onselectedindexchanged="ddl_Programas_SelectedIndexChanged" Width="300px">
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="btn_Proceder" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="PROCEDER" Width="300px" onclick="Button1_Click" />
</p>
<p>
    <asp:Label ID="Label9" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Visible="False"></asp:Label>
</p>
<p>
    <asp:Label ID="Label8" runat="server" 
        style="font-weight: 700; font-size: small; color: #FFFFFF; text-align: left; font-family: Arial, Helvetica, sans-serif;" 
        Text="Seleccione la Versión:" Width="300px" Visible="False"></asp:Label>
    <br />
    <asp:DropDownList ID="ddl_Versiones" runat="server" Width="300px" 
        Visible="False">
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: 700; font-size: small; color: #FFFFFF; text-align: left; font-family: Arial, Helvetica, sans-serif;" 
        Text="Seleccione un Módulo:" Width="300px" Visible="False"></asp:Label>
    <br />
    <asp:DropDownList ID="ddl_Modulos" runat="server" Width="300px" Visible="False">
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="font-weight: 700; font-size: small; color: #FFFFFF; text-align: left; font-family: Arial, Helvetica, sans-serif;" 
        Text="Seleccione a un Docente:" Width="300px" Visible="False"></asp:Label>
    <br />
    <asp:DropDownList ID="ddl_Docentes" runat="server" Width="300px" 
        Visible="False">
    </asp:DropDownList>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label10" runat="server" 
        style="font-weight: 700; font-size: small; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Fecha de Inicio del Módulo:" Visible="False" Width="300px"></asp:Label>
</p>
<p>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
        BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
        Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
        style="margin-left: 545px" Visible="False" Width="300px">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
        <NextPrevStyle VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#808080" />
        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" />
        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
        <WeekendDayStyle BackColor="#FFFFCC" />
    </asp:Calendar>
</p>
<p>
    <asp:Label ID="Label11" runat="server" 
        style="font-size: small; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-weight: 700; text-align: left" 
        Text="Fecha de Finalización:" Visible="False" Width="300px"></asp:Label>
</p>
<p>
    <asp:Calendar ID="Calendar2" runat="server" BackColor="White" 
        BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
        Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
        style="margin-left: 545px" Visible="False" Width="298px">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
        <NextPrevStyle VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#808080" />
        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" />
        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
        <WeekendDayStyle BackColor="#FFFFCC" />
    </asp:Calendar>
</p>
<p>
    &nbsp;&nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label7" runat="server" 
        style="font-weight: 700; color: #FF0000; font-family: Arial, Helvetica, sans-serif"></asp:Label>
</p>
<p>
    <asp:Button ID="btn_Registrar" runat="server" style="font-weight: 700" 
        Text="REGISTRAR" Width="300px" onclick="btn_Registrar_Click" 
        Visible="False" />
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
