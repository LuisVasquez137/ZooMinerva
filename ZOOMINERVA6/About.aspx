<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ZOOMINERVA6.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <asp:Image ID="Image1" runat="server" />

    <h3 style="background-image: url('images/madera.jpg')">
        <table class="nav-justified" style="background-image: url('images/madera3.jpg')">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center"><span style="font-size: larger;"><strong>INFORMACIÓN</strong></span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">&nbsp;</td>
                <td class="text-center">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">&nbsp;</td>
                <td class="text-center"><span style="font-size: larger"><strong>MISIÓN:</strong></span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:Label ID="LabelMision" runat="server" Text="Label"></asp:Label>
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
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center"><span style="font-size: larger"><strong>VISIÓN:</strong></span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 28px"></td>
                <td style="height: 28px"></td>
                <td class="text-center" style="height: 28px">
                    <asp:Label ID="LabelVision" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 28px"></td>
                <td style="height: 28px"></td>
            </tr>
            <tr>
                <td style="height: 28px"></td>
                <td style="height: 28px"></td>
                <td class="text-center" style="height: 28px"></td>
                <td style="height: 28px"></td>
                <td style="height: 28px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center"><span style="font-size: larger"><strong>DIRECCIÓN:</strong></span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:Label ID="LabelDireccion" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center"><span style="font-size: larger"><strong>TELEFONO:</strong></span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:Label ID="LabelTelefono" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center"><span style="font-size: larger"><strong>HORARIO:</strong></span></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:Label ID="LabelHorario" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center"><strong>¿COMO LLEGAR?</strong></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp; </td>
                <td class="text-center">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </h3>
    <p class="text-center" ><iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3856.6140489290556!2d-91.53568203950164!3d14.84690370290916!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x7c4a6a8ce1854b96!2sParque+Zoologico!5e0!3m2!1ses!2ses!4v1472026025447" width="1550" height="550" frameborder="0" style="border:0" allowfullscreen></iframe>&nbsp;</p>
</asp:Content>
