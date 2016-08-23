<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarObjetivosEspecificos.aspx.cs" Inherits="QualificationsWebSystem.RegistrarObjetivosEspecificos" %>
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
            style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
            Text="REGISTRAR PLAN GLOBAL"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p class="style6">
        <strong>2. OBJETIVOS ESPECÍFICOS.</strong></p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label4" runat="server" 
            style="text-align: left; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
            Text="Escriba un Objetivo Específico:" Width="600px"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txt_Objetivos" runat="server" Height="69px" 
            TextMode="MultiLine" Width="600px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lbl_Mensaje" runat="server" 
            style="color: #FF0000; font-family: Arial, Helvetica, sans-serif; font-weight: 700"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="25px" onclick="Button1_Click" 
            style="font-weight: 700" Text="REGISTRAR OBJETIVO ESPECÍFICO" Width="400px" />
    </p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
            Visible="False">Registrar otro Objetivo Específico</asp:LinkButton>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
            Visible="False" onclick="LinkButton2_Click">Ir a 3. Contenido Temático</asp:LinkButton>
    </p>
    <p>
        <br />
    </p>
    <p>
    </p>
</asp:Content>
