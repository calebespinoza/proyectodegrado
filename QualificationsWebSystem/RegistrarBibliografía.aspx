<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarBibliografía.aspx.cs" Inherits="QualificationsWebSystem.RegistrarBibliografía" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style6
    {
        font-family: Arial, Helvetica, sans-serif;
        color: #FFFFFF;
        background-color: #003399;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-size: large" 
        Text="REGISTRAR PLAN GLOBAL"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p class="style6">
    <strong>8. BIBLIOGRAFÍA SUGERIDA.</strong></p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label7" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Título:" Width="400px"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_Titulo" runat="server" Height="40px" TextMode="MultiLine" 
        Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label8" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Autor: " Width="100px"></asp:Label>
    <asp:TextBox ID="txt_Autor" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label9" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left" 
        Text="Editorial: " Width="100px"></asp:Label>
    <asp:TextBox ID="txt_Editorial" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label10" runat="server" 
        style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; margin-left: 0px" 
        Text="Año: " Width="100px"></asp:Label>
    <asp:TextBox ID="txt_año" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="font-weight: 700; color: #FF0000; font-family: Arial, Helvetica, sans-serif"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Height="25px" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="REGISTRAR" Width="300px" />
</p>
<p>
    <asp:LinkButton ID="LinkButton1" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Visible="False">Registrar Nueva Bibliografía</asp:LinkButton>
</p>
<p>
    <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Visible="False">Ir a la Página Principal</asp:LinkButton>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
