<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="ElegirModulo.aspx.cs" Inherits="QualificationsWebSystem.ElegirModulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
</p>
    <p>
</p>
<p>
<asp:Label ID="Label3" runat="server" 
    style="color: #FFFFFF; font-weight: 700; font-size: large; font-family: Arial, Helvetica, sans-serif;" 
    Text="REGISTRAR PLAN GLOBAL"></asp:Label>
    </p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        style="margin-left: 47px" Width="1139px">
        <Columns>
            <asp:HyperLinkField NavigateUrl="~/RegistrarPlanGlobal.aspx" 
                Text="Registrar Plan Global" DataNavigateUrlFields="Módulo,Programa,Versión" 
                
                DataNavigateUrlFormatString="RegistrarPlanGlobal.aspx?ModuleName={0}&amp;ProgramName={1}&amp;ID={2}" />
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
</asp:Content>
