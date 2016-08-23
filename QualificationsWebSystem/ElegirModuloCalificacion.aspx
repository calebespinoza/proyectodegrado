﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="ElegirModuloCalificacion.aspx.cs" Inherits="QualificationsWebSystem.RegistrarCalificacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="REGISTRAR CALIFICACIONES" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-size: large"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        style="margin-left: 250px" Width="850px">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Módulo,Programa,Versión" 
                DataNavigateUrlFormatString="RegistrarCalificación.aspx?ModuleName={0}&amp;ProgramName={1}&amp;ID={2}" 
                NavigateUrl="~/RegistrarCalificación.aspx" Text="Seleccionar Módulo" />
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
</asp:Content>
