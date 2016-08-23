<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ModificarApertura.aspx.cs" Inherits="QualificationsWebSystem.ModificarApertura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    </p>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large; color: #FFFFFF" 
        Text="MODIFICAR APERTURA DE PROGRAMA DE POSTGRADO"></asp:Label>
    <br />
    <br />
    <br />
<p>
    <asp:Label ID="Label4" runat="server" 
        style="text-align: left; font-size: medium; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-weight: 700" 
        Text="Programa de Postgrado:" Width="260px"></asp:Label>
    <asp:DropDownList ID="ddl_Programas" runat="server" Width="250px" 
        DataSourceID="SqlDataSource1" DataTextField="ProgramName" 
        DataValueField="ProgramName">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:QualificationsDBConnectionString %>" 
        
        SelectCommand="SELECT [ProgramName] FROM [GraduateProgram] ORDER BY [ProgramName]">
    </asp:SqlDataSource>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Fecha de Inicio:" Width="510px"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
        BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
        Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="140px" 
        style="margin-left: 700px" Width="279px">
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
    <asp:Label ID="Label6" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #FFFFFF; font-weight: 700; text-align: left" 
        Text="Fecha de Finalización:" Width="510px"></asp:Label>
</p>
<asp:Calendar ID="Calendar2" runat="server" BackColor="White" 
    BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
    Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="140px" 
    style="margin-left: 700px" Width="279px">
    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
    <NextPrevStyle VerticalAlign="Bottom" />
    <OtherMonthDayStyle ForeColor="#808080" />
    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" />
    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
    <WeekendDayStyle BackColor="#FFFFCC" />
</asp:Calendar>
<p>
    <asp:Label ID="Label7" runat="server" 
        style="text-align: left; font-weight: 700; font-size: medium; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="Versión:" Width="260px"></asp:Label>
    <asp:DropDownList ID="ddl_Version" runat="server" Width="250px" 
        DataSourceID="SqlDataSource2" DataTextField="ProgramVersion" 
        DataValueField="ProgramVersion">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:QualificationsDBConnectionString2 %>" 
        SelectCommand="SELECT [ProgramVersion] FROM [Version]"></asp:SqlDataSource>
&nbsp;
    </p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FF0000"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="font-weight: 700" Text="MODIFICAR APERTURA" Height="28px" 
        Width="300px" />
</p>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
