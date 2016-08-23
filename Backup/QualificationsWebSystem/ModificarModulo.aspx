<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="ModificarModulo.aspx.cs" Inherits="QualificationsWebSystem.ModificarModulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    </p>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: 700; color: #FFFFFF" 
        Text="MODIFICAR DATOS DEL MÓDULO"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Nombre del Módulo:" Width="300px" 
        
        
    style="color: #FFFFFF; font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left;"></asp:Label>
    <asp:TextBox ID="txt_ModuleName" runat="server" Width="300px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Modalidad:" Width="450px" 
        
        
    
    style="color: #FFFFFF; font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left;"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButtonList ID="rbl_Mode" runat="server" 
        
    
    
        style="text-align: left; margin-left: 700px; font-weight: 700; font-family: Arial, Helvetica, sans-serif;">
        <asp:ListItem Selected="True">Presencial</asp:ListItem>
        <asp:ListItem Value="Semipresencial"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="Label6" runat="server" 
    Text="Reasignar a un Programa de Postgrado:" Width="300px" 
        
        
    
    
        style="color: #FFFFFF; font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left;"></asp:Label>
    <asp:DropDownList ID="ddl_Programas" runat="server" Width="300px">
</asp:DropDownList>
<br />
<br />
<br />
    <br />
<asp:Label ID="lbl_mensaje" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FF0000"></asp:Label>
<br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="31px" onclick="Button1_Click" 
        Text="MODIFICAR MÓDULO" Width="338px" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif;" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
