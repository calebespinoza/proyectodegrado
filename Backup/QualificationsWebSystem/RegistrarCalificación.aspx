<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarCalificación.aspx.cs" Inherits="QualificationsWebSystem.RegistrarCalificación" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-size: large" 
        Text="REGISTRAR CALIFICACIONES"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lbl_nameModulo" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
        Text="LISTA DE ESTUDIANTES INSCRITOS AL MÓDULO"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        style="margin-left: 250px" Width="815px">
        <Columns>
            <asp:CommandField SelectText="Seleccionar Estudiante" ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="lbl_nombreEstudiante" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btn_RegistrarParciales" runat="server" Height="27px" 
        onclick="btn_RegistrarParciales_Click" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="REGISTRAR EVALUACIONES PARCIALES" Visible="False" Width="350px" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_RegistrarFinal" runat="server" Height="27px" 
        onclick="btn_RegistrarFinal_Click" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="REGISTRAR EVALUACIÓN FINAL" Visible="False" Width="350px" />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: right" 
        Text="Seleccione la Evaluación Parcial: " Visible="False" Width="350px"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddl_Evaluacion" runat="server" 
        onselectedindexchanged="ddl_Evaluacion_SelectedIndexChanged" Visible="False" 
        Width="200px">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: right" 
        Text="Ponderación Registrada:  " Visible="False" Width="350px"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbl_Ponderacion" runat="server" Height="18px" 
        style="text-align: left; font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Visible="False" Width="200px"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FFFFFF; text-align: right" 
        Text="Calificación de la Evaluación: " Visible="False" Width="350px"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Visible="False" Width="200px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_mensaje" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FF0000"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btn_notaParcial" runat="server" Height="26px" 
        onclick="btn_notaParcial_Click" 
        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
        Text="Registrar Nota Parcial" Visible="False" Width="250px" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_notaFinal" runat="server" Height="26px" 
        onclick="btn_notaFinal_Click" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="Registrar Nota Final" Visible="False" Width="250px" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
