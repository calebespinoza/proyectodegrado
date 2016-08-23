<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarAvanceContenido.aspx.cs" Inherits="QualificationsWebSystem.RegistrarAvanceContenido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;<asp:Label ID="Label3" runat="server" 
            style="font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF" 
            Text="REGISTRAR AVANCE DE CONTENIDO TEMÁTICO"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label4" runat="server"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
            style="margin-left: 391px" Width="580px">
            <Columns>
                <asp:CommandField SelectText="Seleccionar Tema" ShowSelectButton="True" />
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
    </p>
    <p>
        <asp:Label ID="lbl_tema" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif; font-weight: 700"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
            Text="REGISTRAR" Width="300px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
