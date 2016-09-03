<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteDiagnostico.aspx.cs" Inherits="ZOOMINERVA6.ReporteDiagnostico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center"><%: Title %>.INGRESE EL CODIGO DEL ANIMAL</h2>
    <p>
        <table class="nav-justified" style="background-image: url('images/madera3.jpg')">
            <tr>
                <td class="text-center">&nbsp;</td>
                <td class="text-center"><strong><span style="font-size: x-large">Código</span></strong>:</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Dotted"></asp:TextBox>
                </td>
                <td class="text-center">
                    <asp:Button ID="Button1" runat="server" BorderStyle="Dotted" Height="35px" Text="Buscar" Width="115px" OnClick="Button1_Click" />
                </td>
                <td class="text-center">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px"></td>
                <td style="height: 22px"></td>
                <td style="height: 22px"></td>
                <td style="height: 22px"></td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td class="text-center" style="font-size: x-large; height: 44px">
                    <strong>Alias:</strong></td>
                <td class="text-center" style="height: 44px"><strong><span style="font-size: x-large">Nombre común:</span></strong></td>
                <td class="text-center" style="font-size: x-large; height: 44px"><strong>Nombre cientifico:</strong></td>
                <td class="text-center" style="height: 44px"><strong><span style="font-size: x-large">Sexo:</span></strong></td>
                <td class="text-center" style="height: 44px"></td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelAlias" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelNombreComun" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelNombreCientifico" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelSexo" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td style="height: 22px">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td style="height: 22px">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px" colspan="5">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        .</p>
</asp:Content>
