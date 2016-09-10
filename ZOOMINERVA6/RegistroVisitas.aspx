<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroVisitas.aspx.cs" Inherits="ZOOMINERVA6.RegistroVisitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >

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
        <div class="text-center" style="background-image: url('images/beige2.jpg');">
            <tr>
            <td style=" background-image: url('images/beige2.jpg'); color: #003399;" class="auto-style11" colspan="4"><span class="auto-style1" style="font-family: 'Comic Sans MS'"><span style="font-size: xx-large">REGISTRO DE VISITAS</td>
      
                </td>
                  </tr>
                
            </span>
                
            </div>
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id_registro" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id_registro" HeaderText="Id_registro" InsertVisible="False" ReadOnly="True" SortExpression="Id_registro" />
                    <asp:BoundField DataField="Fecha_visita" HeaderText="Fecha_visita" SortExpression="Fecha_visita" />
                    <asp:BoundField DataField="Hora_ingreso" HeaderText="Hora_ingreso" SortExpression="Hora_ingreso" />
                    <asp:BoundField DataField="Establecimiento" HeaderText="Establecimiento" SortExpression="Establecimiento" />
                    <asp:BoundField DataField="Direccion_establecimiento" HeaderText="Direccion_establecimiento" SortExpression="Direccion_establecimiento" />
                    <asp:BoundField DataField="NoAlumnos" HeaderText="NoAlumnos" SortExpression="NoAlumnos" />
                    <asp:BoundField DataField="Grado" HeaderText="Grado" SortExpression="Grado" />
                    <asp:BoundField DataField="Donacion" HeaderText="Donacion" SortExpression="Donacion" />
                    <asp:BoundField DataField="Telefono_establecimiento" HeaderText="Telefono_establecimiento" SortExpression="Telefono_establecimiento" />
                    <asp:BoundField DataField="Coentarios" HeaderText="Coentarios" SortExpression="Coentarios" />
                    <asp:BoundField DataField="Nombre_paquete" HeaderText="Nombre_paquete" SortExpression="Nombre_paquete" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" SelectCommand="Porc_ListaVisitas" SelectCommandType="StoredProcedure"></asp:SqlDataSource>

        </div>

        <div class="marco2">

            <table class="nav-justified">
                <tr>
                    <td class="auto-style2" colspan="4">Planifica una nueva visita</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">¿Que paquete?</td>
                    <td class="auto-style3">
                       <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" Height="19px" Width="167px" DataSourceID="SqlDataSource2" DataTextField="Nombre_paquete" DataValueField="Id_paquete">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" SelectCommand="SELECT * FROM [PaquetesEducativos]"></asp:SqlDataSource>
                    </td>
                    <span class="auto-style1" style="font-family: 'Comic Sans MS'">
                    <td class="auto-style5">Fecha de la visita:&nbsp; </td>
     </span>
                    <td class="auto-style3">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>Hora planificada:</td>
                    <td>
                        <asp:TextBox ID="TextBoxHora" runat="server"></asp:TextBox>
                    </td>
                    <span class="auto-style1" style="font-family: 'Comic Sans MS'">
                    <td>&nbsp;</td>
     </span>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Nombre del establecimiento:</td>
                    <td>
                        <asp:TextBox ID="TextBoxEstablecimiento" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Dirección</td>
                    <td>
                        <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
                    </td>
                    <td><span class="auto-style1" style="font-family: 'Comic Sans MS'">
                        <asp:Button ID="ButtonGuardar" runat="server" Height="43px" OnClick="ButtonGuardar_Click" Text="Guardar" />
                        <asp:Button ID="ButtonEditar" runat="server" Height="44px" Text="Editar" Width="126px" OnClick="ButtonEditar_Click" />
     </span>
                    </td>
                    <td>
                        <asp:Button ID="ButtonSalir" runat="server" Text="Salir" />
                    </td>
                </tr>
                <tr>
                    <td>¿Cuantas personas vendran?</td>
                    <td>
                        <asp:TextBox ID="TextBoxAlumnos" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Grado:</td>
                    <td>
                        <asp:TextBox ID="TextBoxGrado" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Telefono:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td>Comentarios:</td>
                    <td>
                        <asp:TextBox ID="TextBoxComentarios" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>

    </div>
     </span>
</asp:Content>
