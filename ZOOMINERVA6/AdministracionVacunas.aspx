<<<<<<< HEAD
﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionVacunas.aspx.cs" Inherits="ZOOMINERVA6.AdministracionVacunas" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
        <div class="panel-info">
            <div class="panel-heading">
        <center><strong style="font-size: x-large">Administración de vacunas </strong></center>

    
    

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Vacuna</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtVacuna" runat="server" Width="294px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Estado</td>
                <td class="auto-style3">
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
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnAgregar" runat="server" Text="Guardar" OnClick="btnAgregar_Click" class="btn btn-primary active" />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" class="btn btn-primary active"/>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success active"/>
                    <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" CssClass="btn btn-info active" Text="Exportar" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" class="btn btn-danger active" />
                </td>
                <td colspan="3">
                    <asp:Label ID="lblMensajes" runat="server" ForeColor="#CC0000" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>

    </div>
    <div class="panel-body">

        <asp:GridView ID="gvListado" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" class="table table-striped">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_vacuna" HeaderText="ID" />
                <asp:BoundField DataField="nombre_vacuna" HeaderText="Nombre" />
                <asp:BoundField DataField="estado_vacuna" HeaderText="Estado" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>            
        </asp:GridView>

    </div>
            </div>
</asp:Content>
=======
﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionVacunas.aspx.cs" Inherits="ZOOMINERVA6.AdministracionVacunas" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
        <div class="panel-info">
            <div class="panel-heading">
        <center><strong style="font-size: x-large">Administración de vacunas </strong></center>

    
    

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Vacuna</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtVacuna" runat="server" Width="294px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Estado</td>
                <td class="auto-style3">
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
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnAgregar" runat="server" Text="Guardar" OnClick="btnAgregar_Click" class="btn btn-primary active" />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" class="btn btn-primary active"/>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success active"/>
                    <asp:Button ID="btnExportar" runat="server" OnClick="btnExportar_Click" CssClass="btn btn-info active" Text="Exportar" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" class="btn btn-danger active" />
                </td>
                <td colspan="3">
                    <asp:Label ID="lblMensajes" runat="server" ForeColor="#CC0000" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>

    </div>
    <div class="panel-body">

        <asp:GridView ID="gvListado" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" class="table table-striped">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_vacuna" HeaderText="ID" />
                <asp:BoundField DataField="nombre_vacuna" HeaderText="Nombre" />
                <asp:BoundField DataField="estado_vacuna" HeaderText="Estado" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>            
        </asp:GridView>

    </div>
            </div>
</asp:Content>
>>>>>>> origin/master
