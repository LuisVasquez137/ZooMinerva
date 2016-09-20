<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministracionEspecie.aspx.cs" Inherits="ZOOMINERVA6.AdministracionEspecie" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

      <style type="text/css">

           .fondo {
               background-image: url('images/madera4.jpg');
           }

            .marco2 {
             
               border-radius: 20px;
               
               margin: 50px;
               width:auto;
               font-size: small; 
              
               background-image: url('images/beige2.jpg');
                color: #003399;
    
    
           }
             .auto-style1 {
             font-size: x-large;
         }
         .auto-style2 {
             font-size: x-large;
             text-align: center;
         }
         .auto-style3 {
             height: 193px;
         }
         .auto-style4 {
             height: 32px;
         }
             .auto-style5 {
             height: 193px;
             text-align: right;
         }
             </style>



    <div class="fondo">

    

    <br /><br /><br /><br /><br /><br />
    <div class="panel-info">
    <div class="panel-heading">    
        <center><strong style="font-size: x-large">Administración de especies </strong> </center>
    
        <div class="marco2">
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
                    <asp:Button ID="btnRefrescar" runat="server" Text="Cancelar" class="btn btn-danger  active" OnClick="btnRefrescar_Click"/>
                </td>
                <td class="auto-style3" colspan="4">
                    <asp:Label ID="lblMensajes" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
            </div>
    </div>
        <div class="panel-body">
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
        </div>
</asp:Content>