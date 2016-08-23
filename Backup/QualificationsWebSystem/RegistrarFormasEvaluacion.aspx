<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarFormasEvaluacion.aspx.cs" Inherits="QualificationsWebSystem.RegistrarFormasEvaluacion" %>
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
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="REGISTRAR PLAN GLOBAL"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p class="style6">
    <strong>7. FORMAS DE EVALUACIÓN DE APRENDIZAJES CONSIDERADOS.</strong></p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Forma de Evaluación: " Width="200px"></asp:Label>
    <asp:DropDownList ID="ddl_Forma" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif" Width="300px">
        <asp:ListItem>Individual</asp:ListItem>
        <asp:ListItem>Grupal</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Breve Descripción: " Width="500px"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_Descripcion" runat="server" Height="70px" 
        TextMode="MultiLine" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left" 
        Text="Justificación: " Width="500px"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_Justificacion" runat="server" Height="70px" 
        TextMode="MultiLine" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FF0000"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="REGISTRAR FORMA DE EVALUACIÓN" Width="400px" />
</p>
<p>
    <asp:LinkButton ID="LinkButton1" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Visible="False">Registrar Nueva Forma de Evaluación</asp:LinkButton>
</p>
<p>
    <asp:LinkButton ID="LinkButton2" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Visible="False">Ir a 8. Bibliografía Sugerida</asp:LinkButton>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
