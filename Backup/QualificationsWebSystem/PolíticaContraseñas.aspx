<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="PolíticaContraseñas.aspx.cs" Inherits="QualificationsWebSystem.PolíticaContraseñas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
<br />
<asp:Label ID="Label3" runat="server" 
    style="font-weight: 700; color: #FFFFFF; font-size: large; font-family: Arial, Helvetica, sans-serif" 
    Text="CONFIGURAR POLÍTICAS DE CONTRASEÑAS"></asp:Label>
<br />
<br />
<br />
<br />
<br />
<asp:Label ID="Label4" runat="server" 
    style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
    Text="Exigir caracteres en &quot;Minúsculas&quot;:" Width="270px"></asp:Label>
<br />
<asp:RadioButtonList ID="rbl_Minusculas" runat="server" 
    
    
    
        style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; margin-left: 581px">
    <asp:ListItem>Habilitar</asp:ListItem>
    <asp:ListItem>Deshabilitar</asp:ListItem>
</asp:RadioButtonList>
<br />
<asp:Label ID="Label5" runat="server" 
    style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
    Text="Exigir caracteres en &quot;Mayúsculas&quot;:" Width="270px"></asp:Label>
<br />
<asp:RadioButtonList ID="rbl_Mayusculas" runat="server" 
    
    
        style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; margin-left: 581px">
    <asp:ListItem>Habilitar</asp:ListItem>
    <asp:ListItem>Deshabilitar</asp:ListItem>
</asp:RadioButtonList>
<br />
<asp:Label ID="Label6" runat="server" 
    style="text-align: left; font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FFFFFF" 
    Text="Exigir caracteres &quot;Numerales&quot;:" Width="270px"></asp:Label>
<br />
<asp:RadioButtonList ID="rbl_Numeros" runat="server" 
    
        style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; margin-left: 581px">
    <asp:ListItem>Habilitar</asp:ListItem>
    <asp:ListItem>Deshabilitar</asp:ListItem>
</asp:RadioButtonList>
<br />
<asp:Label ID="Label7" runat="server" 
    style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
    Text="Longitud Mínima de Contraseña:" Width="270px"></asp:Label>
<asp:TextBox ID="txt_minimo" runat="server" Width="50px"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label8" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left; margin-bottom: 0px" 
    Text="Longitud Máxima de Contraseña:" Width="270px"></asp:Label>
<asp:TextBox ID="txt_maximo" runat="server" Width="50px"></asp:TextBox>
    <br />
<br />
<br />
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="font-weight: 700; color: #FF0000; font-family: Arial, Helvetica, sans-serif"></asp:Label>
    <br />
<br />
<br />
<asp:Button ID="Button1" runat="server" Height="31px" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Text="GUARDAR CONFIGURACIONES" Width="321px" onclick="Button1_Click" />
<br />
<br />
<br />
</asp:Content>
