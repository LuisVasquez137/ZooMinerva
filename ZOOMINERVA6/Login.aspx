<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ZOOMINERVA6.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="background-image: url('images/login.jpg'); font-size: x-large; color: #FFFFFF;">
        <tr>
            <td style="height: 103px; width: 182px">&nbsp;</td>
            <td style="height: 103px">&nbsp;</td>
            <td style="height: 103px">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="height: 103px">&nbsp;</td>
            <td style="height: 103px">&nbsp;</td>
            <td style="height: 103px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 103px; width: 182px">
                <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td style="height: 103px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="height: 103px"><span style="font-size: medium">Nota: Este registro esta diseñado exclusivamente para
                <br />
                personal del zoológico minerva, si usted es empleado y<br />
                todavia no tiene un usuario y contraseña,</span></td>
            <td style="height: 103px">
                &nbsp;</td>
            <td style="height: 103px"></td>
            <td style="height: 103px"></td>
        </tr>
        <tr>
            <td style="width: 182px">
                <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td><span style="font-size: medium">registrese en la administración del zoologico minerva</span></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 182px">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 182px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingreso" Width="270px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 182px">&nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 182px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 182px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 182px; height: 190px;"></td>
            <td style="height: 190px"></td>
            <td style="height: 190px"></td>
            <td style="height: 190px"></td>
            <td style="height: 190px"></td>
            <td style="height: 190px"></td>
        </tr>
    </table>
</asp:Content>
