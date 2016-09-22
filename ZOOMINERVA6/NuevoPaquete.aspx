<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoPaquete.aspx.cs" Inherits="ZOOMINERVA6.NuevoPaquete" %>
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
             </style>



    <asp:UpdatePanel runat="server">
        <ContentTemplate>


     <div class="fondo">

    <h2><%: Title %>.<asp:Image ID="Image2" runat="server" />
    </h2>

   

   
    <div class="text-center" style="background-image: url('images/beige2.jpg');">
            <tr>
            <td style=" background-image: url('images/beige2.jpg'); color: #003399;" class="auto-style11" colspan="4"><span class="auto-style1" style="font-family: 'Comic Sans MS'"><span style="font-size: xx-large">ADMINISTRACION DE PAQUETES EDUCATIVOS</td>
      
                </td>
                  </tr>
                
            </span>
                
            </div>
    <br />



     <div class="text-center">
        
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_paquete" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />

            <Columns>
                <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Id_paquete" HeaderText="CODIGO" InsertVisible="False" ReadOnly="True" SortExpression="Id_paquete" />
                <asp:BoundField DataField="Nombre_paquete" HeaderText="NOMBRE DEL PAQUETE" SortExpression="Nombre_paquete" />
                <asp:BoundField DataField="Tema" HeaderText="TEMA" SortExpression="Tema" />
                <asp:BoundField DataField="Objetivos" HeaderText="OBJETIVOS" SortExpression="Objetivos" />
                <asp:BoundField DataField="Donacion_p_p" HeaderText="COSTO POR PERSONA" SortExpression="Donacion_p_p" />
                <asp:BoundField DataField="Incluye" HeaderText="LO QUE INCLUYE" SortExpression="Incluye" />
            </Columns>    
        </asp:GridView>

         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" DeleteCommand="DELETE FROM [PaquetesEducativos] WHERE [Id_paquete] = @original_Id_paquete AND [Nombre_paquete] = @original_Nombre_paquete AND [Tema] = @original_Tema AND [Objetivos] = @original_Objetivos AND (([Donacion_p_p] = @original_Donacion_p_p) OR ([Donacion_p_p] IS NULL AND @original_Donacion_p_p IS NULL)) AND (([Incluye] = @original_Incluye) OR ([Incluye] IS NULL AND @original_Incluye IS NULL))" InsertCommand="INSERT INTO [PaquetesEducativos] ([Nombre_paquete], [Tema], [Objetivos], [Donacion_p_p], [Incluye]) VALUES (@Nombre_paquete, @Tema, @Objetivos, @Donacion_p_p, @Incluye)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [PaquetesEducativos]" UpdateCommand="UPDATE [PaquetesEducativos] SET [Nombre_paquete] = @Nombre_paquete, [Tema] = @Tema, [Objetivos] = @Objetivos, [Donacion_p_p] = @Donacion_p_p, [Incluye] = @Incluye WHERE [Id_paquete] = @original_Id_paquete AND [Nombre_paquete] = @original_Nombre_paquete AND [Tema] = @original_Tema AND [Objetivos] = @original_Objetivos AND (([Donacion_p_p] = @original_Donacion_p_p) OR ([Donacion_p_p] IS NULL AND @original_Donacion_p_p IS NULL)) AND (([Incluye] = @original_Incluye) OR ([Incluye] IS NULL AND @original_Incluye IS NULL))">
             <DeleteParameters>
                 <asp:Parameter Name="original_Id_paquete" Type="Int32" />
                 <asp:Parameter Name="original_Nombre_paquete" Type="String" />
                 <asp:Parameter Name="original_Tema" Type="String" />
                 <asp:Parameter Name="original_Objetivos" Type="String" />
                 <asp:Parameter Name="original_Donacion_p_p" Type="Decimal" />
                 <asp:Parameter Name="original_Incluye" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="Nombre_paquete" Type="String" />
                 <asp:Parameter Name="Tema" Type="String" />
                 <asp:Parameter Name="Objetivos" Type="String" />
                 <asp:Parameter Name="Donacion_p_p" Type="Decimal" />
                 <asp:Parameter Name="Incluye" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="Nombre_paquete" Type="String" />
                 <asp:Parameter Name="Tema" Type="String" />
                 <asp:Parameter Name="Objetivos" Type="String" />
                 <asp:Parameter Name="Donacion_p_p" Type="Decimal" />
                 <asp:Parameter Name="Incluye" Type="String" />
                 <asp:Parameter Name="original_Id_paquete" Type="Int32" />
                 <asp:Parameter Name="original_Nombre_paquete" Type="String" />
                 <asp:Parameter Name="original_Tema" Type="String" />
                 <asp:Parameter Name="original_Objetivos" Type="String" />
                 <asp:Parameter Name="original_Donacion_p_p" Type="Decimal" />
                 <asp:Parameter Name="original_Incluye" Type="String" />
             </UpdateParameters>
         </asp:SqlDataSource>
           
    </div>
         <div class="marco2">

        
    <p>.<table class="nav-justified">
        <tr>
            <td class="text-center" colspan="5">INGRESE UN NUEVO PAQUETE EDUCATIVO</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-right"><strong>Nombre del paquete:</strong></td>
            <td class="text-left">
                <asp:TextBox ID="TextBoxNombre" runat="server" Width="408px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-right"><strong>Tema:</strong></td>
            <td class="text-left">
                <asp:TextBox ID="TextBoxTema" runat="server" Width="415px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td class="text-center" style="height: 22px"></td>
            <td class="text-center" style="height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-right">Objetivos:</td>
            <td class="text-left">
                <asp:TextBox ID="TextBoxObjetivos" runat="server" Width="410px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-right"><strong>Donación:</strong></td>
            <td class="text-left">
                <asp:TextBox ID="TextBoxDonacion" runat="server" Width="414px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-right"><strong>¿Que incluye?</strong></td>
            <td class="text-left">
                <asp:TextBox ID="TextBoxIncluye" runat="server" Width="412px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td class="text-center" style="height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="height: 22px">&nbsp;</td>
            <td class="text-center" style="height: 22px">&nbsp;</td>
            <td style="height: 22px">&nbsp;</td>
            <td style="height: 22px">&nbsp;</td>
            <td style="height: 22px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="5"><span class="auto-style1" style="font-family: 'Comic Sans MS'">
                <asp:Button ID="Button1" runat="server" BackColor="#00CC00" OnClick="Button1_Click" Text="Guardar" Width="110px" />
                <asp:Button ID="Button2" runat="server" BackColor="Red" OnClick="Button2_Click" Text="Salir" Width="106px" />
                </span></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-left">
                <strong>
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </strong>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center" colspan="4">&nbsp;</td>
        </tr>
        </table>

         
        <p>
        </p>
        <p>
        </p>
    </p>
    
    </div>
            
    </span>
    
    </div>
          
            </ContentTemplate>
            
        </asp:UpdatePanel>
</asp:Content>
