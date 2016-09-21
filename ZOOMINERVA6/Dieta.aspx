<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dieta.aspx.cs" Inherits="ZOOMINERVA6.Dieta" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
    <div class="panel panel-default">
        <div class="panel heading">
            <center><strong style="font-size: x-large">Administración de Dietas</strong></center>
            
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Genero</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlGeneros" runat="server" Height="22px" Width="193px" >
                    </asp:DropDownList>
                </td>
                <td>Unidad</td>
                
                <td>
                    <asp:DropDownList ID="ddlUnidad" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ingrediente</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlIngrediente" runat="server" Height="27px" Width="191px">
                    </asp:DropDownList>
                </td>
                <td>Peso</td>
                <td>
                    <asp:TextBox ID="txtPeso" runat="server" Height="16px" Width="40px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Presentación</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPresentacion" runat="server" Height="16px" Width="184px"></asp:TextBox>
                </td>
                <td>Estado</td>
                <td>
                    <asp:DropDownList ID="ddlEstado" runat="server" >
                        <asp:ListItem Value="-1">::Seleccionar::</asp:ListItem>
                        <asp:ListItem Value="1">Habilitado</asp:ListItem>
                        <asp:ListItem Value="0">Deshabilitado</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                
                <td colspan="2">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" class="btn btn-primary active"  />
                    <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" class="btn btn-primary active"/>
                    <asp:Button ID="txtBuscar" runat="server" OnClick="txtBuscar_Click" Text="Buscar" class="btn btn-success active"/>
                    <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" class="btn btn-info active" Text="Exportar" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" class="btn btn-danger active" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblMensaje" runat="server" Text="MENSAJE" CssClass="label-danger" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
        </table>

    </div>
         <div id="datos">
            
        <div class="panel-body">
       <asp:GridView ID="gvListado" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" class="table table-striped" >
            <Columns>
                <asp:BoundField DataField="idDieta" HeaderText="ID" />
                <asp:BoundField DataField="Id_genero" HeaderText="ID GENERO" Visible="False" />
                <asp:BoundField DataField="Id_ingrediente" HeaderText="ID INGREDIENTE" Visible="False" />
                <asp:BoundField DataField="Id_Unidad" HeaderText="ID UNIDAD" Visible="False" />
                <asp:BoundField DataField="Peso" HeaderText="Peso" />
                <asp:BoundField DataField="Presentacion" HeaderText="Presentación" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>

    
            </div>
        </div>
    
</asp:Content>
