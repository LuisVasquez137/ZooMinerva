<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nuevo empleado.aspx.cs" Inherits="ZOOMINERVA6.Nuevo_empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">

           .fondo {
               background-image: url('images/madera4.jpg');
               background-attachment :fixed;
             
           }
             </style>
    <div class="fondo">

    

   <h2><%: Title %><asp:Image ID="Image2" runat="server" />
    </h2>

    <style type="text/css">

           .marco2 {
             
               border-radius: 20px;
               
               margin: 50px;
               width:auto;
               font-size: small; 
              
               background-image: url('images/beige2.jpg');
                color: #003399;
    
    
           }
              </style>

    <style type="text/css">

           .radio {
             
               border-radius: 8px;
               
    
           }
              .auto-style1 {
            font-size: xx-large;
        }
              </style>

            <div class="text-center" style="background-image: url('images/beige2.jpg');">
            <tr>
            <td style=" background-image: url('images/beige2.jpg'); color: #003399;" class="auto-style11" colspan="4"><span class="auto-style1" style="font-family: 'Comic Sans MS'">ADMINISTRACION DE EMPLEADOS</td>
      
                </td>
                  </tr>
                
            </div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>

                        <div>
                            <br />
                        </div>

     <div>
        <div class="text-center">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CODIGO" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" HorizontalAlign="Center" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" InsertVisible="False" ReadOnly="True" SortExpression="CODIGO" />
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
                <asp:BoundField DataField="APELLIDO" HeaderText="APELLIDO" SortExpression="APELLIDO" />
                <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
                <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" SortExpression="DIRECCION" />
                <asp:BoundField DataField="FECHA_INICIO" HeaderText="FECHA_INICIO" SortExpression="FECHA_INICIO" />
                <asp:BoundField DataField="CARGO" HeaderText="CARGO" SortExpression="CARGO" />
                <asp:BoundField DataField="DESCRIPCION" HeaderText="DESCRIPCION" SortExpression="DESCRIPCION" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" SelectCommand="sp_listadoEmpleados" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </div>

    <div class="marco2">

    
    
    <table style="font-family: 'Comic Sans MS'; font-size: large;" >
        <tr>
            <td class="text-center" colspan="5">DATOS DEL NUEVO USUARIO</td>
        </tr>
        <tr>
            <td style="width: 76px; height: 29px;"></td>
            <td style="width: 183px; height: 29px;"></td>
            <td style="height: 29px; width: 454px;" colspan="2"></td>
            <td style="height: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 76px; height: 44px;" rowspan="8"></td>
            <td style="height: 44px; width: 183px;" class="text-right">Nombres:</td>
            <td style="height: 44px; width: 454px;">
                <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="radio"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td style="height: 44px; width: 454px;">
                &nbsp;Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBoxUsuario" runat="server" CssClass="radio"></asp:TextBox>
            </td>
            <td style="height: 44px" rowspan="8">

                

                Fecha ingreso:<asp:Calendar ID="Calendar1" runat="server" style="margin-top: 9px" BackColor="#CCCCCC"></asp:Calendar>
                      
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 183px">Apellidos:</td>
            <td style="height: 44px; width: 454px;">
                <asp:TextBox ID="TextBoxApellido" runat="server" CssClass="radio"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
            </td>
            <td style="height: 44px; width: 454px;">
                Contraseña:<asp:TextBox ID="TextBoxContrasenia" runat="server" CssClass="radio" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 183px">Telefono:</td>
            <td style="height: 44px; width: 454px;" colspan="2">
                <asp:TextBox ID="TextBoxTelefono" runat="server" CssClass="radio"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 183px">Dirección</td>
            <td style="height: 44px; width: 454px;" colspan="2">
                <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="radio"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 183px">Cargo:</td>
            <td style="height: 44px; width: 454px;" colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" Height="19px" Width="167px" DataSourceID="SqlDataSource2" DataTextField="Nombre_cargo" DataValueField="Id_cargo">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" SelectCommand="SELECT * FROM [Cargo_Empleado]"></asp:SqlDataSource>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 183px">&nbsp;</td>
            <td style="height: 44px; width: 454px;" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" colspan="3">
                <asp:Button ID="Button1" runat="server" Text="Guardar nuevo empleado" OnClick="Button1_Click" Width="279px" BackColor="#009933" />
                <asp:Button ID="ButtonEditar" runat="server" OnClick="ButtonEditar_Click1" Text="Editar" />
                <asp:Button ID="Button4" runat="server" BackColor="Red" Text="DardeBaja" OnClick="Button4_Click" />
                <asp:Button ID="ButtonSalir" runat="server" OnClick="ButtonSalir_Click" Text="Salir" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 183px">&nbsp;</td>
            <td style="height: 44px; width: 454px;" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        </table>
          </ContentTemplate>
                    </asp:UpdatePanel>
   
   </div>

        </div>
</span>
</asp:Content>
