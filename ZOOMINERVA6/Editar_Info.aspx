<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar_Info.aspx.cs" Inherits="ZOOMINERVA6.Editar_Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">

           .fondo {
               background-image: url('images/madera4.jpg');
               background-attachment :fixed;
             
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
            font-size: large;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: center;
        }
              </style>

    <div class="fondo">
        <br />
        <div class="marco2">

        
        <table class="nav-justified" style="font-size: larger">
            <tr>
                <td class="auto-style2" colspan="3"><strong>FORMULARIO PARA EDITAR LA INFORMACIÓN DEL ZOO</strong></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1"><strong>INFORMACION:</strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxZoo" runat="server" TextMode="MultiLine" Width="900px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><span class="auto-style1"></td>
                <td><strong>MISIÓN:</strong></span></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxMision" runat="server" TextMode="MultiLine" Width="900px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1"><strong>VISIÓN:</strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxVision" runat="server" TextMode="MultiLine" Width="900px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><span class="auto-style1"></td>
                <td><strong>DIRECCIÓN:</strong></span></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxDireccion" runat="server" TextMode="MultiLine" Width="900px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><strong></strong></td>
                <td class="auto-style1"><strong>TELEFONO:</strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxTelefono" runat="server" TextMode="MultiLine" Width="900px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><span class="auto-style1"></td>
                <td><strong>HORARIO:</strong></span></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxHorario" runat="server" TextMode="MultiLine" Width="900px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <asp:Button ID="Button1" runat="server" Text="GUARDAR CAMBIOS" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" BackColor="#FF3300" Text="CANCELAR" OnClick="Button2_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="text-center">
                    <strong>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
        </table>

            </div>
        <div>
.
        </div>


    </div>
</asp:Content>
