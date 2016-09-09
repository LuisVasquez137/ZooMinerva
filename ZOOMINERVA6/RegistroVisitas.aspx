<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroVisitas.aspx.cs" Inherits="ZOOMINERVA6.RegistroVisitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

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

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Fecha_visita" HeaderText="FECHA DE LA VISITA" SortExpression="Fecha_visita" />
                <asp:BoundField DataField="Hora_ingreso" HeaderText="HORA PLANEADA" SortExpression="Hora_ingreso" />
                <asp:BoundField DataField="Establecimiento" HeaderText="ESTABLECIMIENTO" SortExpression="Establecimiento" />
                <asp:BoundField DataField="Direccion_establecimiento" HeaderText="DIRECCION" SortExpression="Direccion_establecimiento" />
                <asp:BoundField DataField="NoAlumnos" HeaderText="NUMERO DE PERSONAS" SortExpression="NoAlumnos" />
                <asp:BoundField DataField="Grado" HeaderText="GRADO" SortExpression="Grado" />
                <asp:BoundField DataField="Donacion" HeaderText="DONACION TOTAL" SortExpression="Donacion" />
                <asp:BoundField DataField="Telefono_establecimiento" HeaderText="TELEFONO" SortExpression="Telefono_establecimiento" />
                <asp:BoundField DataField="Coentarios" HeaderText="COMENTARIOS" SortExpression="Coentarios" />
                <asp:BoundField DataField="Nombre_paquete" HeaderText="NOMBRE DEL PAQUETE" SortExpression="Nombre_paquete" />
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

        <div class="marco2">

            <table class="nav-justified">
                <tr>
                    <td class="auto-style2" colspan="4">Planifica una nueva visita</td>
                </tr>
                <tr>
                    <td class="auto-style3">¿Que paquete?</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Nombre_paquete" DataValueField="Id_paquete">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" SelectCommand="SELECT * FROM [PaquetesEducativos]"></asp:SqlDataSource>
                    </td>
                    <span class="auto-style1" style="font-family: 'Comic Sans MS'">
                    <td class="auto-style3">Fecha de la visita</td>
     </span>
                    <td class="auto-style3">
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>Hora planificada:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <span class="auto-style1" style="font-family: 'Comic Sans MS'">
                    <td>&nbsp;</td>
     </span>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Nombre del establecimiento:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Dirección</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>¿Cuantas personas vendran?</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Grado:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Telefono:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td>Comentarios:</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>

    </div>
     </span>
</asp:Content>
