<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authentication.aspx.cs" Inherits="QualificationsWebSystem.Authentication" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#85b7cf">
    <form id="form1" runat="server">
    <div style="width: 1272px; margin-left: 3px; text-align: center; height: 246px;">
    
        <asp:Label ID="Label2" runat="server" Text="ESCUELA DE COMANDO Y ESTADO MAYOR" 
            style="font-weight: 700; text-align: center; font-size: x-large"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="DIVISIÓN DE PROGRAMAS DE POSTGRADO" 
            style="font-weight: 700; font-size: large"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="93px" 
            ImageUrl="ecemlogo.jpg" 
            Width="106px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="SISTEMA DE CALIFICACIONES" 
            style="font-weight: 700; font-size: large"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    
        <asp:Login ID="LoginForm" runat="server" BackColor="#EFF3FB" 
            BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="222px" 
            onauthenticate="Login1_Authenticate" 
            
        style="text-align: justify; font-family: Arial; font-size: large; margin-left: 441px; margin-top: 0px;" 
        Width="385px" onload="Page_Load" onloggedin="Page_Load" 
        FailureText="Su intento de inicio de sesión no se ha realizado correctamente. Por favor, inténtalo de nuevo." 
        LoginButtonText="Ingresar" PasswordLabelText="Contraseña:" 
        PasswordRequiredErrorMessage="Se necesita la Contraseña." 
        RememberMeText="Recordarme la próxima vez." UserNameLabelText="Cuenta:" 
        UserNameRequiredErrorMessage="Se necesita la Cuenta de Usuario.">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                ForeColor="#284E98" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                ForeColor="White" />
        </asp:Login>
    
        <p style="text-align: center; width: 1275px">
            &nbsp;</p>
    <p style="text-align: center; width: 1275px">
        <asp:Label ID="lbl_Inhabil" runat="server" 
            style="color: #FF0000; font-size: large; font-weight: 700"></asp:Label>
    </p>
    <p style="text-align: center; width: 1275px">
        &nbsp;</p>
    <p style="text-align: center; width: 1275px">
        <asp:Label ID="Label4" runat="server" 
            Text="Derechos Reservados. Copyrigth 2011" 
            style="font-weight: 700; text-align: center; font-size: small"></asp:Label>
    </p>
    </form>
</body>
</html>
