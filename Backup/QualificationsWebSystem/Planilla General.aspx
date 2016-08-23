<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="Planilla General.aspx.cs" Inherits="QualificationsWebSystem.Planilla_General" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
    <p>
        &nbsp;</p>
<asp:Label ID="Label3" runat="server" 
    style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
    Text="PLANILLA GENERAL DEL DOCENTE"></asp:Label>
    <br />
<br />
    <br />
    <strong>
    <asp:Label ID="Label5" runat="server" CssClass="style6" 
        Text="Seleccione un Estudiante:"></asp:Label>
&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="217px">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="font-weight: 700" Text="DESPLEGAR CALIFICACIONES" Width="326px" />
    <br />
<br class="style6" />
    </strong>
<br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
    GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged" 
        style="margin-left: 447px" Width="420px">
    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
<br />
<br />
    <asp:Label ID="lbl_Total" runat="server" style="font-weight: 700"></asp:Label>
<br />
    <br />
<br />
<br />
</asp:Content>
