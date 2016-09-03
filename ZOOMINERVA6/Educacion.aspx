<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Educacion.aspx.cs" Inherits="ZOOMINERVA6.Educacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.<asp:Image ID="Image2" runat="server" />
    </h2>
    <p style="background-image: url('images/madera3.jpg')">
        
        <table class="nav-justified" style="background-image: url('images/madera3.jpg')">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center"><strong style="font-family: Arial, Helvetica, sans-serif; font-size: 35px">PAQUETES EDUCATIVOS</strong></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" HorizontalAlign="Center">
                        <HeaderStyle BackColor="#006600" BorderStyle="Dotted" HorizontalAlign="Center" />
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            </table>

    </p>
</asp:Content>
