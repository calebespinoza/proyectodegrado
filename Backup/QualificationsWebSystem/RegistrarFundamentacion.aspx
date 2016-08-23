<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarFundamentacion.aspx.cs" Inherits="QualificationsWebSystem.RegistrarFundamentacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            font-family: Arial, Helvetica, sans-serif;
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="margin-top: 0px; margin-bottom: 3px">
        <asp:Label ID="Label6" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large; color: #FFFFFF" 
            Text="REGISTRAR PLAN GLOBAL"></asp:Label>
    </p>
    <p style="margin-top: 0px; margin-bottom: 3px">
        <br />
    </p>
    <p class="style6" 
        style="margin-top: 0px; margin-bottom: 3px; background-color: #003399">
        <strong>1. FUNDAMENTACIÓN Y OBJETIVO GENERAL.</strong></p>
    <p style="margin-top: 0px; margin-bottom: 3px">
        &nbsp;</p>
    <p>
        <asp:Label ID="Label4" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-size: medium; text-align: left" 
            Text="Registre la Fundamentación:" Width="600px"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txt_Fundamentacion" runat="server" Height="150px" 
            style="margin-top: 3px" TextMode="MultiLine" Width="600px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label5" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
            Text="Registre el Objetivo General del Módulo:" Width="600px"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txt_Objetivo" runat="server" Height="60px" 
            TextMode="MultiLine" Width="600px"></asp:TextBox>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lbl_Mensaje" runat="server" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FF0000"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="25px" onclick="Button1_Click" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
            Text="REGISTRAR" Width="400px" />
    </p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
            style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
            Visible="False">Ir a 2. Objetivos Específicos</asp:LinkButton>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
