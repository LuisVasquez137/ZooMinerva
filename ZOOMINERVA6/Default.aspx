<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ZOOMINERVA6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


     <table class="nav-justified">
    <tr>
        <td style="background-color: #000000; font-size: medium;">
            <table style="width: 100%">
                <tr>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td style="color: #FFFFFF">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButton8" runat="server" ForeColor="White">Inventario general</asp:LinkButton>
                    </td>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButton9" runat="server" ForeColor="White" OnClick="LinkButton9_Click">Nacimientos</asp:LinkButton>
                    </td>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButton10" runat="server" ForeColor="White">Muertes</asp:LinkButton>
                    </td>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButton11" runat="server" ForeColor="White">Cuarentena</asp:LinkButton>
                    </td>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButton12" runat="server" ForeColor="White">Enrequecimiento</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton13" runat="server" ForeColor="White">Donaciones</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton15" runat="server" ForeColor="White" OnClick="LinkButton15_Click" >Administrar empleados</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton14" runat="server" ForeColor="White">Instrucciones generales</asp:LinkButton>
                    </td>
                </tr>
                
                <tr>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButton17" runat="server" ForeColor="White" OnClick="LinkButton17_Click">Paquetes educativos</asp:LinkButton>
                    </td>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButton18" runat="server" ForeColor="White" OnClick="LinkButton18_Click">Historial medico</asp:LinkButton>
                    </td>
                    <td style="color: #FFFFFF">
                        <asp:LinkButton ID="LinkButtonVisitas" runat="server" OnClick="LinkButtonVisitas_Click" style="color: #FFFFFF" Visible="False">Administracion visitas</asp:LinkButton>
                    </td>
                    <td style="color: #FFFFFF">
                        &nbsp;</td>
                    <td style="color: #FFFFFF">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Visible="False" Width="191px">
                            <asp:ListItem>Empleados</asp:ListItem>
                            <asp:ListItem>Cargos</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="text-align: center">
                        <asp:LinkButton ID="LinkButton16" runat="server" ForeColor="White" OnClick="LinkButton16_Click">CERRAR SESIÓN</asp:LinkButton>
                    </td>
                </tr>
                
            </table>
             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick"></asp:Timer>
            <asp:Image ID="Image1" runat="server" />
            </ContentTemplate>
    </asp:UpdatePanel>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td><p style="width: 1534px; height: 1170px;">
    <br />
   

            </table>


    

   



</asp:Content>
