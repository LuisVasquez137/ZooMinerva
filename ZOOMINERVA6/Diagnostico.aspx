<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Diagnostico.aspx.cs" Inherits="ZOOMINERVA6.Diagnostico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <style type="text/css">

           .marco2 {
             
               border-radius: 20px;
               
               margin: 50px;
               width:auto;
               font-size: small; 
              
               background-image: url('images/beige2.jpg');
                color: #003399;
                border-bottom:20px;
    
    
           }

           .fondo {
               background-image: url('images/madera4.jpg');
               background-attachment :fixed;
             
               
           }
              </style>
    <div class="fondo">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
   
    
     <h2 class="text-center"><%: Title %>.</h2>
    <asp:Image ID="Image1" runat="server" />
        <div class="marco2" >
    <p class="text-center"><strong><span style="font-size: x-large">D</span></strong><span style="font-weight: bold"><span style="font-size: x-large">IAGNOSTICO DEL PACIENTE:</span></span><strong><table align="center" class="nav-justified" font-size: larger;">
       
    

           
        
      <tr>
            <td style="width: 205px; height: 31px;"></td>
            <td class="text-center" style="width: 307px; height: 31px;">INGRESE CODIGO DEL ANIMAL</td>
            <td style="height: 31px"></td>
            <td style="height: 31px">
                <asp:TextBox ID="TextBoxCodigoAnimal" runat="server"></asp:TextBox>
            </td>
            <td style="height: 31px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-center" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>historial:</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="height: 22px; width: 205px;">Fecha del diagnostico:</td>
            <td style="height: 22px; width: 307px;" class="text-left">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" style="cursor:pointer">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </td>
            <td style="height: 22px">&nbsp;</td>
            <td style="height: 22px">Motivo de la consulta:</td>
            <td style="height: 22px">
                <asp:TextBox ID="TextBoxMotivo" runat="server" Height="107px" TextMode="MultiLine" Width="316px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px; width: 205px;">Peso:</td>
            <td style="height: 22px; width: 307px;" class="text-left">
                <asp:TextBox ID="TextBoxPeso" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px"></td>
            <td style="height: 22px">&nbsp;</td>
            <td rowspan="4">
                <asp:TextBox ID="TextBoxAnamnesis" runat="server" Height="101px" TextMode="MultiLine" Width="309px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 38px; width: 205px;">Temperatura:<br />
            </td>
            <td style="height: 38px; width: 307px;" class="text-left">
                <asp:TextBox ID="TextBoxTemperatura" runat="server"></asp:TextBox>
            </td>
            <td style="height: 38px"></td>
            <td style="height: 38px"><strong>Anamnesis:</strong></td>
        </tr>
        <tr>
            <td style="width: 205px">F. cardiaca:</td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxCardiaca" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">F. respiratoria:</td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxRespiratoria" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">Tllc:</td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxTllc" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">Mucosas:</td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxMucosas" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td rowspan="4">
                <asp:TextBox ID="TextBoxEnfermedades" runat="server" Height="88px" TextMode="MultiLine" Width="323px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 205px">Tungencia de piel:</td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxTungencia" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>Enfermedades anteriores:</td>
        </tr>
        <tr>
            <td style="width: 205px">pulso:</td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxPulso" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td></strong></td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Actitud:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxActitud" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Condición corporal:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxCondicionCorporal" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td rowspan="3">
                <asp:TextBox ID="TextBoxProblemasEncontrados" runat="server" Height="73px" TextMode="MultiLine" Width="325px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Hidratación:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxHidratacion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td><strong>Problemas</strong> encontrados:</td>
        </tr>
        <tr>
            <td style="height: 26px; width: 205px;"><strong>Ojos:</strong></td>
            <td style="height: 26px; width: 307px;" class="text-left">
                <asp:TextBox ID="TextBoxojos" runat="server"></asp:TextBox>
            </td>
            <td style="height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Oidos:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxOidos" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Nodulos linfaticos:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxNodulos" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Locomocion:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxLocomocion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td rowspan="3"><strong>
                <asp:TextBox ID="TextBoxDiagnosticoPresuntivo" runat="server" Height="67px" TextMode="MultiLine" Width="319px"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Musculo esqueletico:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxMusculoEsqueletico" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td><strong>Diagnostico presuntivo:</strong></td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Nervioso:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxNervioso" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Cardiovascular:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxCardiobascular" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Digestivo:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxDigestivo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td rowspan="3">
                <asp:TextBox ID="TextBoxDiagnosticoDefinitivo" runat="server" Height="59px" TextMode="MultiLine" Width="316px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Respiratorio:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxRespiratorio" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td><strong>Diagnostico definitivo:</strong></td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Genitouriano:</strong></td>
            <td class="text-left" style="width: 307px">
                <asp:TextBox ID="TextBoxGeniouriano" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px"><strong>Resultados</strong>:</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="5">
                <asp:TextBox ID="TextBoxResultados" runat="server" Height="82px" TextMode="MultiLine" Width="1375px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 205px">Informe de <strong>progreso</strong>:</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="5">
                <asp:TextBox ID="TextBoxProgreso" runat="server" Height="131px" TextMode="MultiLine" Width="1375px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="width: 205px">&nbsp;</td>
            <td class="text-left" style="width: 307px">
                <asp:Button ID="Button1" runat="server" Height="49px" Text="Guardar" Width="198px" OnClick="Button1_Click" />
            </td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="Button2" runat="server" Height="45px" Text="Cancelar" Width="217px" />
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="5">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="5">&nbsp;</td>
        </tr>
        </table>
       
     </p>
            </div>
     </strong>
                </ContentTemplate>
            </asp:UpdatePanel>
     </div>
    <div class="fondo">

    </div>
 
</asp:Content>
