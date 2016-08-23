<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="QualificationsWebSystem.RegistrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            text-align: left;
            font-weight: 700;
            color: #FFFFFF;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style9
        {
            color: #FFFFFF;
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;<asp:Label ID="Label3" runat="server" Text="REGISTRAR NUEVO USUARIO" 
            
            style="font-weight: 700; color: #FFFFFF; font-size: large; font-family: Arial, Helvetica, sans-serif;"></asp:Label>
    </p>
<p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center; background-color: #000066;" class="style9">
        <strong>Datos Personales</strong></p>
    <p style="text-align: center">
        <asp:Label ID="Label7" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FFFFFF; text-align: left;" 
            Text="Nombre:" Width="200px"></asp:Label>
        <asp:TextBox ID="txt_Nombre" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label8" runat="server" CssClass="style8" 
            Text="Apellido Paterno:" Width="200px"></asp:Label>
        <asp:TextBox ID="txt_APaterno" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label9" runat="server" CssClass="style8" 
            Text="Apellido Materno:" Width="200px"></asp:Label>
        <asp:TextBox ID="txt_AMaterno" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label10" runat="server" CssClass="style8" 
            Text="Carnet de Identidad:" Width="200px"></asp:Label>
        <asp:TextBox ID="txt_CI" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label22" runat="server" 
            style="font-size: medium; font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left" 
            Text="Sexo:" Width="200px"></asp:Label>
        <asp:DropDownList ID="ddl_Sexo" runat="server" Width="210px">
        <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
            <asp:ListItem Value="Maculino">Masculino</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label18" runat="server" CssClass="style8" Text="Profesión: " 
            Width="200px"></asp:Label>
        <asp:TextBox ID="txt_Profesion" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label11" runat="server" CssClass="style8" Text="Email:" 
            Width="200px"></asp:Label>
        <asp:TextBox ID="txt_Email" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label12" runat="server" CssClass="style8" Text="Celular:" 
            Width="200px"></asp:Label>
        <asp:TextBox ID="txt_Celular" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label13" runat="server" CssClass="style8" Text="Teléfono:" 
            Width="200px"></asp:Label>
        <asp:TextBox ID="txt_Fono" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        &nbsp;<asp:Label ID="Label15" runat="server" CssClass="style8" Text="Domicilio:" 
            Width="200px"></asp:Label>
        <asp:TextBox ID="txt_Domicilio" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label16" runat="server" CssClass="style8" Text="Departamento:" 
            Width="200px"></asp:Label>
        <asp:DropDownList ID="ddl_Departamento" runat="server" Height="23px" 
            Width="200px">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="Beni">Beni</asp:ListItem>
            <asp:ListItem Value="Chuquisaca">Chuquisaca</asp:ListItem>
            <asp:ListItem Value="Cochabamba">Cochabamba</asp:ListItem>
            <asp:ListItem Value="La Paz">La Paz</asp:ListItem>
            <asp:ListItem Value="Oruro">Oruro</asp:ListItem>
            <asp:ListItem Value="Pando">Pando</asp:ListItem>
            <asp:ListItem Value="Potosi">Potosi</asp:ListItem>
            <asp:ListItem Value="Santa Cruz">Santa Cruz</asp:ListItem>
            <asp:ListItem Value="Tarija">Tarija</asp:ListItem>
            
        </asp:DropDownList>
    </p>
    <p style="text-align: center">
        &nbsp;<asp:Label ID="Label21" runat="server" 
            style="font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left" 
            Text="Casilla Postal:" Width="200px"></asp:Label>
        <asp:TextBox ID="txt_CPostal" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center; background-color: #000066;" class="style9">
        <strong style="background-color: #000066">Cuenta de Usuario</strong></p>
    <p style="text-align: center">
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Cuenta de Usuario:" Width="200px" 
            style="color: #FFFFFF; font-weight: 700;" CssClass="style8"></asp:Label>
&nbsp;<asp:TextBox ID="txt_Cuenta" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p style="text-align: center">
        <asp:Label ID="Label5" runat="server" Text="Contraseña:" Width="200px" 
            style="color: #FFFFFF; font-weight: 700;" CssClass="style8"></asp:Label>
        &nbsp;<asp:TextBox ID="txt_Pass" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
        </p>
<p style="text-align: center">
        <asp:Label ID="Label23" runat="server" 
            style="font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left" 
            Text="Confirmar Contraseña:" Width="200px"></asp:Label>
&nbsp;<asp:TextBox ID="txt_Confirmar" runat="server" Height="18px" TextMode="Password" 
            Width="200px"></asp:TextBox>
        </p>
<p style="text-align: center">
        &nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Estado: " Width="200px" 
            style="color: #FFFFFF; font-weight: 700;" CssClass="style8"></asp:Label>
    &nbsp; 
        <asp:DropDownList ID="ddl_Status" runat="server" Height="23px" 
            Width="205px">
            <asp:ListItem Value="0">Inhabilitado</asp:ListItem>
            <asp:ListItem Value="1">Habilitado</asp:ListItem>
        </asp:DropDownList>
    </p>
<p style="text-align: center">
        &nbsp;&nbsp;
        <asp:Label ID="Label20" runat="server" Text="Rol:" 
            style="font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left;" 
            Width="200px"></asp:Label>
    &nbsp;
        <asp:DropDownList ID="ddl_Rol" runat="server" Width="205px">
            <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="3">Docente</asp:ListItem>
            <asp:ListItem Value="4">Estudiante</asp:ListItem>
        </asp:DropDownList>
    </p>
<p style="text-align: center">
        &nbsp;</p>
<p style="text-align: center">
        <asp:Label ID="lbl_error" runat="server" 
            style="font-weight: 700; color: #FF0000; font-size: medium; font-family: Arial, Helvetica, sans-serif"></asp:Label>
</p>
    <p style="text-align: center">
        &nbsp;<asp:Button ID="Button1" runat="server" style="font-weight: 700; text-align: center;" 
            Text="REGISTRAR" Width="400px" Height="29px" onclick="Button1_Click" />
    </p>
<p style="text-align: center">
        &nbsp;</p>
</asp:Content>
