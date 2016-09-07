<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresarNoticias.aspx.cs" Inherits="ZOOMINERVA6.IngresarNoticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br /><br /><br />
        <div class="panel-info">
            <div class="panel-heading">
        <center><strong style="font-size: x-large">ADMINISTRACION DE NOTICIAS </strong></center>
                <table class="auto-style1">
            <tr>
                <td class="auto-style2">Titulo de la noticia: </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxTitulo" runat="server" Width="294px"></asp:TextBox>
                </td>
                <td>Descripcion:</td>
                <td>
                    <asp:TextBox ID="TextBoxDescripcion" runat="server" Height="43px" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine" Width="327px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha a relaizarse: </td>
                <td class="auto-style3">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="Gray" Width="303px"></asp:Calendar>
                </td>
                <td class="text-center">Imagen:<br />
                    <asp:Button ID="Button1" runat="server" Height="29px" Text="Button" Width="83px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnAgregar" runat="server" Text="Guardar" OnClick="btnAgregar_Click" class="btn btn-primary active" />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" class="btn btn-primary active"/>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success active"/>
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" class="btn btn-danger active" />
                </td>
                <td colspan="3">
                    <asp:Label ID="lblMensajes" runat="server" ForeColor="#CC0000" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>

</div>
            <div class="panel-body">


                <asp:GridView ID="GridView1" runat="server" Width="1130px" AllowPaging="true" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" AlternatingRowStyle-CssClass="table table-striped">
                    <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id_noticia" HeaderText="CODIGO" />
                <asp:BoundField DataField="fecha" HeaderText="FECHA" />
                <asp:BoundField DataField="Titulo_noticia" HeaderText="TITULO" />
                <asp:CommandField SelectText="Descripcion" HeaderText ="DESCRIPCION DE LA NOTICIA" />
                <asp:CommandField SelectText="Imagen" HeaderText ="IMAGEN" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns> 
                </asp:GridView>


    </div>
            </div>
</asp:Content>

   
