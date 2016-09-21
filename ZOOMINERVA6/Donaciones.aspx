<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Donaciones.aspx.cs" Inherits="ZOOMINERVA6.Donaciones" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
    <div class="panel-info">
    <div class="panel-heading">    
        <center><strong style="font-size: x-large">Administración de donaciones </strong> </center>
    

        <table class="auto-style1">
            <tr>
                <td class="auto-style6">
                    Generol</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlGenero" runat="server" Height="16px" Width="251px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style8">
                    Persona</td>
                <td class="auto-style9">
                    <asp:DropDownList ID="ddlPersona" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style10">Origen</td>
                <td class="auto-style9">
                    <asp:DropDownList ID="ddlOrigen" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Empleado</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="ddlEmpleado" runat="server" Height="16px" Width="241px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    Fecha</td>
                <td>
                    <asp:TextBox ID="txtFechaDonacion" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">Fecha&nbsp; ingreso</td>
                <td>
                    <asp:TextBox ID="txtFechaIngreso" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Motivo</td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtMotivo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    Estado</td>
                <td>
                    <asp:DropDownList ID="ddlEstado" runat="server" Height="16px">
                        <asp:ListItem Value="-1">::Seleccionar::</asp:ListItem>
                        <asp:ListItem Value="1">Habilitado</asp:ListItem>
                        <asp:ListItem Value="0">Deshabilitado</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style12" colspan="5">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary active" OnClick="btnGuardar_Click"   />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary  active" OnClick="btnEditar_Click"  />
                    <asp:Button ID="btnBuscar" runat="server"  Text="Buscar" class="btn btn-success  active" OnClick="btnBuscar_Click"   />
                    <asp:Button ID="btnExportar" runat="server" Text="Exportar" class="btn btn-info active" OnClick="btnExportar_Click" />
                    <asp:Button ID="btnRefrescar" runat="server" Text="Cancelar" class="btn btn-danger  active" OnClick="btnRefrescar_Click"  />
                    <asp:Label ID="lblMensajes" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
        <div class="panel-body">
            <asp:GridView ID="gvListado" runat="server" AllowPaging="True" AutoGenerateColumns="False" class="table table-striped" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id_donacion" HeaderText="ID" />
                <asp:BoundField DataField="Id_animal" HeaderText="Animal" Visible="false" />
                <asp:BoundField DataField="Id_persona" HeaderText="Persona" Visible="false"/>
                <asp:BoundField DataField="Id_origen" HeaderText="Origen" Visible="false"/>
                <asp:BoundField DataField="Id_empleado" HeaderText="Empleado" Visible="false"/>
                <asp:BoundField DataField="Fecha_donacion" HeaderText="Fecha"/>
                <asp:BoundField DataField="Motivo_donacion" HeaderText="Motivacion"/>
                <asp:BoundField DataField="Fecha_ingreso_recinto" HeaderText="Fecha ingreso"/>
                <asp:BoundField DataField="Estado_donacion" HeaderText="Estado" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        </div>
        </div>
</asp:Content>
