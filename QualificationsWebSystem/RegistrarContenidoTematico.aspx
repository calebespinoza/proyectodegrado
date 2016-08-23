<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarContenidoTematico.aspx.cs" Inherits="QualificationsWebSystem.RegistrarContenidoTematico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style6
    {
        font-family: Arial, Helvetica, sans-serif;
        color: #FFFFFF;
        background-color: #003399;
    }
    .style7
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: x-small;
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
    <strong>4. CONTENIDO TEMÁTICO</strong></p>
<p>
    <span class="style7"><strong>Nota.</strong></span> <span class="style7">Todos 
    los campos de texto marcados con * deben ser llenados obligatoriamente</span></p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="text-align: left; font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FFFFFF" 
        Text="* Tema: " Width="150px"></asp:Label>
    <asp:TextBox ID="txt_Tema" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FFFFFF; text-align: left" 
        Text="* Objetivos Instrumentales:" Width="450px"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_ObjInstrumental" runat="server" Height="70px" 
        style="margin-left: 3px" TextMode="MultiLine" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Temas de Investigación:" Width="450px"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_TemaInvest" runat="server" Height="70px" 
        TextMode="MultiLine" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label7" runat="server" 
        style="text-align: left; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-weight: 700" 
        Text="Trabajo Personal:" Width="150px"></asp:Label>
    <asp:TextBox ID="txt_TrabPersonal" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label8" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
        Text="Trabajo Grupal:" Width="150px"></asp:Label>
    <asp:TextBox ID="txt_TrabGrupal" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lbl_mensaje" runat="server" 
        style="font-weight: 700; color: #FF0000; font-family: Arial, Helvetica, sans-serif"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="font-weight: 700" Text="REGISTRAR TEMA" Width="300px" />
</p>
<p>
    <asp:LinkButton ID="LinkButton1" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Visible="False" onclick="LinkButton1_Click">Registrar Nuevo Tema</asp:LinkButton>
</p>
<p>
    <asp:LinkButton ID="LinkButton2" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Visible="False" onclick="LinkButton2_Click">Ir a  5. Métodos de Enseñanza Considerados</asp:LinkButton>
</p>
<p>
    &nbsp;</p>
</asp:Content>
