<%@ Page Title="" Language="C#" MasterPageFile="~/MPAdministrator.Master" AutoEventWireup="true" CodeBehind="RegistrarInscripción.aspx.cs" Inherits="QualificationsWebSystem.RegistrarInscripción" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-size: large; text-align: center;" 
        Text="REGISTRAR INSCRIPCIÓN DE ESTUDIANTES"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="lbl_Estudiante" runat="server" 
        
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large; text-align: center;"></asp:Label>
</p>
<p>
    <asp:Label ID="lbl_NombrePrograma" runat="server" 
        
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large; text-align: center;"></asp:Label>
</p>
<p>
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: 700; font-size: small; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left" 
        Text="Seleccione un Programa de Postgrado:" Width="300px"></asp:Label>
    <br />
    <asp:DropDownList ID="ddl_Programas" runat="server" Width="300px" 
        style="text-align: center" AutoPostBack="True" 
        onselectedindexchanged="ddl_Programas_SelectedIndexChanged">
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label6" runat="server" 
        style="font-weight: 700; font-size: small; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left" 
        Text="Seleccione la versión:" Width="300px"></asp:Label>
</p>
    <p>
    <asp:DropDownList ID="ddl_Versiones" runat="server" Width="300px" 
            onselectedindexchanged="ddl_Versiones_SelectedIndexChanged">
    </asp:DropDownList>
</p>
    <p>
    <asp:Button ID="Button1" runat="server" Height="25px" onclick="Button1_Click" 
        style="font-weight: 700; text-align: center;" Text="CONTINUAR" 
        Width="300px" />
</p>
<p>
    <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
        Visible="False" style="font-family: Arial, Helvetica, sans-serif">Regresar a la página anterior</asp:LinkButton>
    <br />
</p>
<p>
    <asp:Label ID="Label7" runat="server" 
        style="font-weight: 700; font-size: small; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; text-align: left" 
        Text="Seleccione el/los Módulo(s):" Width="300px" Visible="False"></asp:Label>
    <br />
</p>
<p>
    <asp:CheckBox ID="CheckBoxSelectAll" runat="server" 
        oncheckedchanged="CheckBox1_CheckedChanged" Text="TODOS LOS MODULOS" 
        Visible="False" AutoPostBack="True" />
    </p>
    <p>
        <asp:CheckBoxList ID="CheckBoxListMoldulos" runat="server" 
            style="text-align: left; margin-left: 478px">
        </asp:CheckBoxList>
    </p>
<p>
    <asp:Label ID="lbl_Mensaje" runat="server" 
        style="color: #FF0000; font-weight: 700; font-family: Arial, Helvetica, sans-serif"></asp:Label>
</p>
<p>
    <asp:Button ID="btn_Inscribir" runat="server" Height="25px" 
        onclick="btn_Inscribir_Click" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="INSCRIBIR ESTUDIANTE" Width="300px" Visible="False" />
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
