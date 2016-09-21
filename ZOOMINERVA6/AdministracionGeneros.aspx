<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionGeneros.aspx.cs" Inherits="ZOOMINERVA6.AdministracionGeneros" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
        <div class="panel-info">
            <div class="panel-heading">
        <center><strong style="font-size: x-large">Administración de generos </strong></center>

        <table class="auto-style1">
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="lblNombreC" runat="server" Text="Nombre científico"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtNombreCientifico" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblNombreComun" runat="server" Text="Nombre comun"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombreComun" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblCantidad" runat="server" Text="Cantidad"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtCantidad" runat="server" Width="66px"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblEspecie" runat="server" Text="Especie"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEspecies" runat="server" Height="16px" Width="261px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEstado" runat="server">
                        <asp:ListItem Value="-1">::Seleccionar::</asp:ListItem>
                        <asp:ListItem Value="1">Habilitado</asp:ListItem>
                        <asp:ListItem Value="0">Deshabilitado</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" class="btn btn-primary active" />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click"  class="btn btn-primary active"/>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success active"/>
                    <asp:Button ID="btnExportar" runat="server" Text="Exportar" class="btn btn-info active" OnClick="btnExportar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" class="btn btn-danger active"/>
                </td>
                <td>
                    <asp:Label ID="lblMensajes" runat="server" ForeColor="#CC0000" Text="Label" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
            <div class="panel-body">
        <asp:GridView ID="gvListado" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" class="table table-striped">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id_genero" HeaderText="ID" />
                <asp:BoundField DataField="Nombre_cientifico" HeaderText="Científico" />
                <asp:BoundField DataField="Nombre_comun" HeaderText="Comun" />
                <asp:BoundField DataField="Cantidad_ejemplares" HeaderText="Cant." />
                <asp:CommandField ShowSelectButton="True" SelectText="Editar" />
                 
            </Columns>                    
            
        </asp:GridView>
                </div>
            </div>
    

</asp:Content>
