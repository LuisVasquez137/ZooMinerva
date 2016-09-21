<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargoEmpleados.aspx.cs" Inherits="ZOOMINERVA6.CargoEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
    .panel-info {
  border-color: #bce8f1;

}
     .marco2 {
             
               border-radius: 20px;
               
               margin: 50px;
               width:auto;
               font-size: small; 
              
               background-image: url('images/beige2.jpg');
                color: #003399;
    
    
           }
     .fondo {
               background-image: url('images/madera4.jpg');
           }
.panel-info > .panel-heading {
  color: #31708f;
  background-color: #d9edf7;
  border-color: #bce8f1;
}
        .auto-style3 {
            text-align: center;
            width: 607px;
        }
        .auto-style4 {
            width: 607px;
        }
        .auto-style7 {
            width: 678px;
        }
        .auto-style8 {
            width: 766px;
        }
        .auto-style9 {
            text-align: center;
            width: 253px;
        }
        .auto-style10 {
            text-align: center;
            width: 266px;
        }
        .auto-style12 {
            text-align: left;
            border-color: #bce8f1;
        }
        .auto-style13 {
            text-align: center;
            font-size: medium;
        }
        </style>

    <div class="fondo">

   

    <div class="panel-heading">
        <div class="auto-style12">
    <h2><%: Title %><asp:Image ID="Image2" runat="server" />
    </h2>
            
     <div class="text-center" style="background-image: url('images/beige2.jpg');">
        <tr>
            <td style=" background-image: url('images/beige2.jpg'); color: #003399;" class="auto-style11" colspan="4"><span  style="font-family: 'Comic Sans MS'"><span class="auto-style2" style="font-size: xx-large">CARGOS DE EMPLEADOS
                </td>
      
                </td>
                  </tr>
                
         </span>
                
    </div>
            <br />

            <div class="text-left">


    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id_cargo" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="700px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="Id_cargo" HeaderText="CODIGO" InsertVisible="False" ReadOnly="True" SortExpression="Id_cargo" />
            <asp:BoundField DataField="Nombre_cargo" HeaderText="NOMBRE DEL CARGO" SortExpression="Nombre_cargo" />
            <asp:BoundField DataField="Descripcion_cargo" HeaderText="DESCRIPCION DEL CARGO" SortExpression="Descripcion_cargo" />
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

            <div class="marco2">

           
    <table>
        
        <tr>
            <td style=" color: #003399;" rowspan="4" class="auto-style7">&nbsp;</td>
            <td colspan="2" class="auto-style13">

                AGREGAR NUEVO CARGO</td>
        </tr>
        <tr>
            <td class="auto-style10" style="color: #003399;">

                Nombre Cargo:</td>
            <td class="auto-style9" style=" color: #003399;">

                <asp:TextBox ID="TextBox1" runat="server" Width="205px"></asp:TextBox>

            </td>
            <td class="auto-style8" style="color: #003399">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10" style="color: #003399;">

                Descripcion:</td>
            <td class="auto-style9" style="color: #003399;">

                <asp:TextBox ID="TextBox2" runat="server" Width="205px"></asp:TextBox>

            </td>
            <td class="auto-style8" style="color: #003399">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10" style="color: #003399;">

                <asp:Button ID="Button2" runat="server" BackColor="#00CC00" OnClick="Button2_Click" Text="Guardar" />

            </td>
            <td class="auto-style9" style="color: #003399;">

                <asp:Button ID="Button3" runat="server" BackColor="Red" OnClick="Button3_Click" Text="Cancelar" />

            </td>
            <td class="auto-style8" style="color: #003399">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3" colspan="2">

                &nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="4">
                <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" Text="SALIR" Width="176px" />
            </td>
        </tr>
    </table>
                 </div>
    
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" DeleteCommand="DELETE FROM [Cargo_Empleado] WHERE [Id_cargo] = @Id_cargo" InsertCommand="INSERT INTO [Cargo_Empleado] ([Nombre_cargo], [Descripcion_cargo]) VALUES (@Nombre_cargo, @Descripcion_cargo)" SelectCommand="SELECT * FROM [Cargo_Empleado]" UpdateCommand="UPDATE [Cargo_Empleado] SET [Nombre_cargo] = @Nombre_cargo, [Descripcion_cargo] = @Descripcion_cargo WHERE [Id_cargo] = @Id_cargo">
    <DeleteParameters>
        <asp:Parameter Name="Id_cargo" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Nombre_cargo" Type="String" />
        <asp:Parameter Name="Descripcion_cargo" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Nombre_cargo" Type="String" />
        <asp:Parameter Name="Descripcion_cargo" Type="String" />
        <asp:Parameter Name="Id_cargo" Type="Int32" />
    </UpdateParameters>
    </asp:SqlDataSource>

    </div>
   </div>
    </span>

         </div>
</asp:Content>
