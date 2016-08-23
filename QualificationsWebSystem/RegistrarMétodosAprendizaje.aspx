<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarMétodosAprendizaje.aspx.cs" Inherits="QualificationsWebSystem.RegistrarMétodosAprendizaje" %>
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
</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large; color: #FFFFFF" 
        Text="REGISTRAR PLAN GLOBAL"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p class="style6">
    <strong>6. MÉTODOS DE APRENDIZAJE CONSIDERADOS.</strong></p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="Nombre del Método:" Width="180px"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="text-align: left; font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif" 
        Text="Breve Descripción:" Width="480px"></asp:Label>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Height="70px" TextMode="MultiLine" 
        Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left; color: #FFFFFF" 
        Text="Justificación:" Width="480px"></asp:Label>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Height="70px" TextMode="MultiLine" 
        Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="font-weight: 700; color: #FF0000; font-family: Arial, Helvetica, sans-serif"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Height="25px" style="font-weight: 700" 
        Text="REGISTRAR MÉTODO DE ENSEÑANZA" Width="400px" />
</p>
<p>
    <asp:LinkButton ID="LinkButton1" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Visible="False">Registrar Nuevo Tema</asp:LinkButton>
</p>
<p>
    <asp:LinkButton ID="LinkButton2" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Visible="False">Ir a 7. Formas de Evaluación de Aprendizajes Considerados.</asp:LinkButton>
</p>
<p>
    <br />
</p>
</asp:Content>
