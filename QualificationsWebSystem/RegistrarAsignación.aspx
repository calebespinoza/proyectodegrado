<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="RegistrarAsignación.aspx.cs" Inherits="QualificationsWebSystem.RegistrarAsignación" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; color: #FFFFFF; font-size: large" 
        Text="ASIGNAR MÓDULOS A LOS PROGRAMAS DE POSTGRADO"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Programa de Postgrado:" Width="150" 
        style="color: #FFFFFF"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="200px">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Dip">Maestría en Gestión Estratégica Ambiental</asp:ListItem>
            <asp:ListItem Value="Esp">aaaaaa</asp:ListItem>
            <asp:ListItem Value="Maes">Maestria de Desarrollo</asp:ListItem>
            <asp:ListItem Value="Doc">sssssss</asp:ListItem>
            <asp:ListItem Value="Prog">Programa de Testeo</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Módulo:" Width="150" 
        style="color: #FFFFFF"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" Height="25px" Width="200px">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Dip">Introducción al Desarrollo</asp:ListItem>
            <asp:ListItem Value="Maes">Seguridad</asp:ListItem>
            <asp:ListItem Value="Esp">aaaaaa</asp:ListItem>
            <asp:ListItem Value="Doc">Educación y Ética Ambiental</asp:ListItem>
            <asp:ListItem Value="Prog">Introducción al Manejo del SIG</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="35px" style="font-weight: 700" 
        Text="ASIGNAR" Width="336px" />
    <br />
    <br />
    <br />
</asp:Content>
