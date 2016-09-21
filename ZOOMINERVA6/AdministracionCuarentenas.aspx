<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionCuarentenas.aspx.cs" Inherits="ZOOMINERVA6.AdministracionCuarentenas" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
    <div class="panel-info">
    <div class="panel-heading">    
        <center><strong style="font-size: x-large">Administración de cuarentenas </strong> </center>
    

        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    Animal</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlAnimales" runat="server" Height="16px" Width="251px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    Cantidad</td>
                <td>
                    <asp:TextBox ID="txtCantidad" runat="server" Width="83px"></asp:TextBox>
                </td>
                <td>Estado</td>
                <td>
                    <asp:DropDownList ID="ddlEstado" runat="server" Height="16px">
                        <asp:ListItem Value="-1">::Seleccionar::</asp:ListItem>
                        <asp:ListItem Value="1">Habilitado</asp:ListItem>
                        <asp:ListItem Value="0">Deshabilitado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Descripción</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtDescripcion" runat="server" Width="239px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    Fecha</td>
                <td>
                    <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                </td>
                <td>Fecha recinto</td>
                <td>
                    <asp:TextBox ID="txtFechaRecinto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary active" OnClick="btnGuardar_Click"  />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary  active" OnClick="btnEditar_Click" />
                    <asp:Button ID="btnBuscar" runat="server"  Text="Buscar" class="btn btn-success  active" OnClick="btnBuscar_Click"  />
                    <asp:Button ID="btnExportar" runat="server" Text="Exportar" class="btn btn-info active" OnClick="btnExportar_Click"/>
                    <asp:Button ID="btnRefrescar" runat="server" Text="Cancelar" class="btn btn-danger  active" OnClick="btnRefrescar_Click" />
                </td>
                <td class="auto-style3" colspan="4">
                    <asp:Label ID="lblMensajes" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
        <div class="panel-body">
            <asp:GridView ID="gvListado" runat="server" AllowPaging="True" AutoGenerateColumns="False" class="table table-striped" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="Id_Cuarentena" HeaderText="ID" />
                <asp:BoundField DataField="Id_Animal" HeaderText="Animal" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="Descripcion_cuarentena" HeaderText="Descripcion" />
                <asp:BoundField DataField="Fecha_recinto" HeaderText="Fecha Recinto" />
                <asp:BoundField DataField="Cantidad_cuarentena" HeaderText="Cantidad" />
                <asp:BoundField DataField="Estado_cuarentena" HeaderText="Estado" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        </div>

        </div>
</asp:Content>
