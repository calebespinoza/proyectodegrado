<%@ Page Title="" Language="C#" MasterPageFile="~/MPTeacher.Master" AutoEventWireup="true" CodeBehind="RegistrarPlanEvaluaciones.aspx.cs" Inherits="QualificationsWebSystem.RegistrarPlanEvaluaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label3" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-size: large" 
        Text="REGISTRAR PLAN DE EVALUACIONES"></asp:Label>
    <br />
    <asp:Label ID="lbl_titulo" runat="server" 
        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: x-small"></asp:Label>
</p>
<asp:Button ID="btn_Parciales" runat="server" Height="26px" 
    onclick="Button1_Click" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Text="REGISTRAR EVALUACIONES PARCIALES" Width="300px" />
&nbsp;&nbsp;&nbsp;
<asp:Button ID="btn_Final" runat="server" Height="26px" 
    onclick="btn_Final_Click" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Text="REGISTRAR EVALUACIÓN FINAL" Visible="False" Width="300px" />
<br />
<asp:Label ID="Label4" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
    Text="Forma de Evaluación: " Visible="False" Width="250px"></asp:Label>
<asp:DropDownList ID="ddl_formaEvaluacion" runat="server" Visible="False" 
    Width="200px">
</asp:DropDownList>
<br />
<br />
<asp:Label ID="Label5" runat="server" 
    style="font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FFFFFF; text-align: left" 
    Text="Modalidad: " Visible="False" Width="250px"></asp:Label>
<asp:DropDownList ID="ddl_Modalidad" runat="server" Visible="False" 
    Width="200px">
    <asp:ListItem>Oral</asp:ListItem>
    <asp:ListItem>Escrito</asp:ListItem>
    <asp:ListItem>Investigación</asp:ListItem>
</asp:DropDownList>
<br />
<br />
<asp:Label ID="Label7" runat="server" 
    style="font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; font-weight: 700; text-align: left" 
    Text="Descripción: " Visible="False" Width="450px"></asp:Label>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txt_Description" runat="server" Height="70px" 
    TextMode="MultiLine" Visible="False" Width="200px"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label6" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; text-align: left" 
    Text="Porcentaje de Ponderación: " Visible="False" Width="250px"></asp:Label>
<asp:TextBox ID="txt_Ponderación" runat="server" Visible="False" Width="200px"></asp:TextBox>
<asp:Label ID="lbl_Ponderacion" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; text-align: left" 
    Visible="False" Width="200px"></asp:Label>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label9" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: x-small" 
    Text="Del 1 al 100 %" Visible="False"></asp:Label>
<br />
<asp:Label ID="Label8" runat="server" 
    style="color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-weight: 700; text-align: left" 
    Text="Fecha: " Visible="False" Width="450px"></asp:Label>
<br />
<asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
    BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
    Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="161px" 
    style="margin-left: 696px" Visible="False" Width="200px">
    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
    <NextPrevStyle VerticalAlign="Bottom" />
    <OtherMonthDayStyle ForeColor="#808080" />
    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
    <SelectorStyle BackColor="#CCCCCC" />
    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
    <WeekendDayStyle BackColor="#FFFFCC" />
</asp:Calendar>
<br />
<br />
<asp:Label ID="lbl_Mensaje" runat="server" 
    style="font-weight: 700; color: #FF0000; font-family: Arial, Helvetica, sans-serif"></asp:Label>
<br />
<br />
<asp:Button ID="btn_RegistrarParcial" runat="server" Height="26px" 
    onclick="btn_RegistrarParcial_Click" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Text="REGISTRAR EVALUACIÓN" Visible="False" Width="300px" />
<asp:Button ID="btn_EvaluacionFinal" runat="server" Height="26px" 
    onclick="btn_EvaluacionFinal_Click" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Text="REGISTRAR EVALUACIÓN FINAL" Visible="False" Width="250px" />
<br />
<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
    style="font-family: Arial, Helvetica, sans-serif; font-weight: 700" 
    Visible="False">Registrar Nueva Evaluación</asp:LinkButton>
<br />
<br />
<asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Visible="False">Ir al inicio de la página</asp:LinkButton>
<asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Visible="False">Finalizar Registro.</asp:LinkButton>
<br />
<br />
<br />
<asp:Label ID="Label10" runat="server" 
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Text="PLAN DE EVALUACIONES" Visible="False"></asp:Label>
<br />
<asp:GridView ID="GridView1" runat="server" BackColor="White" 
    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    style="margin-left: 250px" Width="855px">
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
    style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" 
    Text="EVALUACIÓN FINAL" Visible="False"></asp:Label>
<br />
<br />
<asp:GridView ID="GridView2" runat="server" BackColor="White" 
    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    style="margin-left: 250px" Width="855px">
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
</asp:Content>
