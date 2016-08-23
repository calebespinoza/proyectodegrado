<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="ListaPlanGlobal.aspx.cs" Inherits="QualificationsWebSystem.Lista_Plan_Global" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" style="font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-size: large;" 
        Text="REPORTE PLAN GLOBAL"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" 
        style="color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: 700" 
        Text="1. IDENTIFICACIÓN."></asp:Label>
    <br />
<br />
<asp:Label ID="lbl_Módulo" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium; text-align: left"></asp:Label>
<br />
<asp:Label ID="lbl_Gestion" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left"></asp:Label>
<br />
<asp:Label ID="lbl_Periodos" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left"></asp:Label>
<br />
<asp:Label ID="lbl_Docente" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left"></asp:Label>
    <br />
    <asp:Label ID="lbl_fecha" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" 
        style="font-weight: 700; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-size: large" 
        Text="2. FUNDAMENTACIÓN."></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gv_Fundamentacion" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" style="margin-left: 200px" Width="885px">
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
    <asp:Label ID="Label6" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif" 
        Text="3. OBJETIVOS (GENERAL Y ESPECÍFICOS)."></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gv_ObjetivoGral" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" style="margin-left: 200px" Width="885px">
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
<asp:GridView ID="gv_ObjEspecificos" runat="server" BackColor="White" 
    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    onselectedindexchanged="gv_ObjEspecificos_SelectedIndexChanged" 
    style="margin-left: 200px" Width="885px">
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
    <asp:Label ID="Label7" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
        Text="4. CONTENIDO TEMÁTICO."></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gv_Contenido" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" style="margin-left: 200px" Width="885px">
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
    <asp:Label ID="Label8" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large" 
        Text="5. MÉTODOS DE ENSEÑANZA CONSIDERADOS."></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gv_MetodosEnseñanza" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" style="margin-left: 200px" Width="883px">
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
    <asp:Label ID="Label9" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif" 
        Text="6. MÉTODOS DE APRENDIZAJE CONSIDERADOS."></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gv_MetodosAprendizaje" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" style="margin-left: 200px" Width="885px">
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
    <asp:Label ID="Label10" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif" 
        Text="7. FORMAS DE EVALUACIÓN DE APRENDIZAJES CONSIDERADOS."></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gv_FormasEvaluacion" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" style="margin-left: 200px" Width="885px">
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
    <asp:Label ID="Label11" runat="server" 
        style="color: #FFFFFF; font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif" 
        Text="8. BIBLIOGRAFÍA SUGERIDA."></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gv_Bibliografia" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
    CellPadding="3" style="margin-left: 200px" Width="884px">
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
    <br />
</asp:Content>
