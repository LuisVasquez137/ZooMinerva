<<<<<<< HEAD
﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionAnimales.aspx.cs" Inherits="ZOOMINERVA6.AdministracionAnimales" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
    <div class="panel-info">
    <div class="panel-heading">
        <center></center><strong style="font-size: x-large">Administración de Animales</strong></center>
           

        <table class="auto-style1">
            <tr>
                <td>Código</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                </td>
                <td>Alias</td>
                <td>
                    <asp:TextBox ID="txtAlias" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">Sexo</td>
                <td>
                    <asp:DropDownList ID="ddlSexo" runat="server">
                        <asp:ListItem>:: Seleccionar ::</asp:ListItem>
                        <asp:ListItem>Macho</asp:ListItem>
                        <asp:ListItem>Hembra</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Edad</td>
                <td>
                    <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                </td>
                <td>Genero</td>
                <td>
                    <asp:DropDownList ID="ddlGenero" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">Estado</td>
                <td>
                    <asp:DropDownList ID="ddlEstado" runat="server" Height="16px" Width="109px">
                        <asp:ListItem Value="-1">::Seleccionar::</asp:ListItem>
                        <asp:ListItem Value="1">Habilitado</asp:ListItem>
                        <asp:ListItem Value="0">Deshabilitado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Causa Muerte</td>
                <td>
                    <asp:TextBox ID="txtCausaMuerte" runat="server"></asp:TextBox>
                </td>
                <td>Nacimiento</td>
                <td>
                    <asp:TextBox ID="txtNacimiento" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">Muerte</td>
                <td>
                    <asp:TextBox ID="txtMuerte" runat="server" Format="dd/MM/yyyy"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="4">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" class="btn btn-primary active"/>
                    <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" class="btn btn-primary active"/>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success active"/>
                    <asp:Button ID="btnExportar" runat="server" Text="Exportar" CssClass="btn btn-info active" OnClick="btnExportar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" class="btn btn-danger active"/>
                </td>
                <td>
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="#CC0000" Text="MENSAJES"></asp:Label>
                </td>
            </tr>
        </table>

    </div>

    <div class="panel-body">

        <asp:GridView ID="gvListado" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" class="table table-striped">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="id_animal" />
                <asp:BoundField HeaderText="Código" DataField="codigo_animal" />
                <asp:BoundField HeaderText="Alias" DataField="alias_animal" />
                <asp:BoundField HeaderText="Sexo" DataField="sexo_animal" />
                <asp:BoundField HeaderText="Estado" DataField="estado_animal" />
                <asp:BoundField HeaderText="Edad" DataField="edad_animal" />
                <asp:BoundField HeaderText="Nacimiento" DataField="fecha_nacimiento" />
                <asp:BoundField HeaderText="Muerte" DataField="fecha_muerte" />
                <asp:BoundField HeaderText="Causa muerte" DataField="causa_muerte" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>
            
        </asp:GridView>

    </div>
  
</asp:Content>
=======
﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionAnimales.aspx.cs" Inherits="ZOOMINERVA6.AdministracionAnimales" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
    <div class="panel-info">
    <div class="panel-heading">
        <center></center><strong style="font-size: x-large">Administración de Animales</strong></center>
           

        <table class="auto-style1">
            <tr>
                <td>Código</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                </td>
                <td>Alias</td>
                <td>
                    <asp:TextBox ID="txtAlias" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">Sexo</td>
                <td>
                    <asp:DropDownList ID="ddlSexo" runat="server">
                        <asp:ListItem>:: Seleccionar ::</asp:ListItem>
                        <asp:ListItem>Macho</asp:ListItem>
                        <asp:ListItem>Hembra</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Edad</td>
                <td>
                    <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
                </td>
                <td>Genero</td>
                <td>
                    <asp:DropDownList ID="ddlGenero" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">Estado</td>
                <td>
                    <asp:DropDownList ID="ddlEstado" runat="server" Height="16px" Width="109px">
                        <asp:ListItem Value="-1">::Seleccionar::</asp:ListItem>
                        <asp:ListItem Value="1">Habilitado</asp:ListItem>
                        <asp:ListItem Value="0">Deshabilitado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Causa Muerte</td>
                <td>
                    <asp:TextBox ID="txtCausaMuerte" runat="server"></asp:TextBox>
                </td>
                <td>Nacimiento</td>
                <td>
                    <asp:TextBox ID="txtNacimiento" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">Muerte</td>
                <td>
                    <asp:TextBox ID="txtMuerte" runat="server" Format="dd/MM/yyyy"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="4">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" class="btn btn-primary active"/>
                    <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" class="btn btn-primary active"/>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success active"/>
                    <asp:Button ID="btnExportar" runat="server" Text="Exportar" CssClass="btn btn-info active" OnClick="btnExportar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" class="btn btn-danger active"/>
                </td>
                <td>
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="#CC0000" Text="MENSAJES"></asp:Label>
                </td>
            </tr>
        </table>

    </div>

    <div class="panel-body">

        <asp:GridView ID="gvListado" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="gvListado_PageIndexChanging" OnSelectedIndexChanged="gvListado_SelectedIndexChanged" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" class="table table-striped">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="id_animal" />
                <asp:BoundField HeaderText="Código" DataField="codigo_animal" />
                <asp:BoundField HeaderText="Alias" DataField="alias_animal" />
                <asp:BoundField HeaderText="Sexo" DataField="sexo_animal" />
                <asp:BoundField HeaderText="Estado" DataField="estado_animal" />
                <asp:BoundField HeaderText="Edad" DataField="edad_animal" />
                <asp:BoundField HeaderText="Nacimiento" DataField="fecha_nacimiento" />
                <asp:BoundField HeaderText="Muerte" DataField="fecha_muerte" />
                <asp:BoundField HeaderText="Causa muerte" DataField="causa_muerte" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>
            
        </asp:GridView>

    </div>
  
</asp:Content>
>>>>>>> origin/master
