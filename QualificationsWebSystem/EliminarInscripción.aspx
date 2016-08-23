<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="EliminarInscripción.aspx.cs" Inherits="QualificationsWebSystem.EliminarInscripción" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="ELIMINAR INSCRIPCIÓN"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lbl_ProgramaPost" runat="server" 
        style="font-weight: 700; font-size: medium; font-family: Arial, Helvetica, sans-serif"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lbl_Version" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: 700"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lbl_Modulo" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lbl_Estudiante" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FF0000" 
        Text="¿Esta seguro (a) de eliminar éste registro de la Base de Datos?"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="btn_Eliminar" runat="server" onclick="btn_Eliminar_Click" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Text="Si, deseo eliminar" />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
