<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarMétodosEnseñanza.aspx.cs" Inherits="QualificationsWebSystem.RegistrarMétodosEnseñanza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style6
    {
        color: #FFFFFF;
        font-family: Arial, Helvetica, sans-serif;
        background-color: #003399;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-size: large" 
        Text="REGISTRAR PLAN GLOBAL"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p class="style6">
    <strong>5. MÉTODOS DE ENSEÑANZA CONSIDERADOS.</strong></p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="Nombre del Método:" Width="200px"></asp:Label>
    <asp:TextBox ID="txt_Método" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="text-align: left; font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif" 
        Text="Breve Descripción: " Width="500px"></asp:Label>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_description" runat="server" Height="70px" TextMode="MultiLine" 
        Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="text-align: left; font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif" 
        Text="Justificación:" Width="500px"></asp:Label>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_Justificacion" runat="server" Height="70px" TextMode="MultiLine" 
        Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="font-weight: 700; color: #FF0000; font-family: Arial, Helvetica, sans-serif"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Height="25px" style="font-weight: 700" 
        Text="REGISTRAR MÉTODO DE ENSEÑANZA" Width="400px" 
        onclick="Button1_Click" />
</p>
<p>
    <asp:LinkButton ID="LinkButton1" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Visible="False" onclick="LinkButton1_Click">Registrar Nuevo Método de Enseñanza</asp:LinkButton>
</p>
<p>
    <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Visible="False">Ir a 6. Métodos de Aprendizaje Considerados.</asp:LinkButton>
</p>
<p>
    &nbsp;</p>
<p>
</p>
</asp:Content>
