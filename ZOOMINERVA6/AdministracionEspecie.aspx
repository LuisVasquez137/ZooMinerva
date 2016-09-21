<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionEspecie.aspx.cs" Inherits="ZOOMINERVA6.AdministracionEspecie" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
    <div class="panel-info">
    <div class="panel-heading" style="background-image: url('images/beige2.jpg')">    
        <center><strong style="font-size: x-large">Administración de especies </strong> </center>
    

        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblNombre" runat="server" Text="Especie"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNombre" runat="server" Height="22px" Width="221px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlEstado" runat="server">
                        <asp:ListItem Value="-1">::Seleccionar::</asp:ListItem>
                        <asp:ListItem Value="1">Habilitado</asp:ListItem>
                        <asp:ListItem Value="0">Deshabilitado</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnGuardar" runat="server" Text="Agregar" class="btn btn-primary active" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary  active" OnClick="btnEditar_Click"/>
                    <asp:Button ID="btnBuscar" runat="server"  Text="Buscar" class="btn btn-success  active" OnClick="btnBuscar_Click" />
                    <asp:Button ID="btnExportar" runat="server" Text="Exportar" class="btn btn-info active" Height="25px" OnClick="btnExportar_Click"/>
                    <asp:Button ID="btnRefrescar" runat="server" Text="Cancelar" class="btn btn-danger  active" OnClick="btnRefrescar_Click"/>
                </td>
                <td class="auto-style3" colspan="4">
                    <asp:Label ID="lblMensajes" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
        <div class="panel-body" style="background-image: url('images/madera3.jpg')">
            <asp:GridView ID="gvListado" runat="server" AllowPaging="True" AutoGenerateColumns="False" class="table table-striped" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="Id_especie" HeaderText="ID" />
                <asp:BoundField DataField="Nombre_especie" HeaderText="Nombre" />
                <asp:BoundField DataField="Estado_especie" HeaderText="Estado" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        </div>

        </div>
</asp:Content>
