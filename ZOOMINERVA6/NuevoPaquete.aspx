<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoPaquete.aspx.cs" Inherits="ZOOMINERVA6.NuevoPaquete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.<asp:Image ID="Image2" runat="server" />
    </h2>
    <p>.<table class="nav-justified" style="background-color:darkseagreen">
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
            <td>&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-left">
                <asp:Button ID="Button1" runat="server" BackColor="#00CC00" OnClick="Button1_Click" Text="Guardar" Width="110px" />
                <asp:Button ID="Button2" runat="server" BackColor="Red" OnClick="Button2_Click" Text="Salir" Width="106px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
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

        
    </p>
    
    <div class="text-center">
        
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

            <Columns>
                <asp:BoundField DataField="id_paquete" HeaderText="CODIGO" />
                <asp:BoundField DataField="Nombre_paquete" HeaderText="NOMBRE" />
                <asp:BoundField DataField="Tema" HeaderText="TEMA" />
                <asp:BoundField DataField="Objetivos" HeaderText="OBJETIVOS" />
                <asp:BoundField DataField="Donacion_p_p" HeaderText="DONACION" />
                <asp:BoundField DataField="Incluye" HeaderText="LO QUE INCLUYE" />
                <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
            </Columns>    
        </asp:GridView>
           
    </div>
            
</asp:Content>
