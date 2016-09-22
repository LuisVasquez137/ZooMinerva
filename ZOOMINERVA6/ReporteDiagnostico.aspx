<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteDiagnostico.aspx.cs" Inherits="ZOOMINERVA6.ReporteDiagnostico" %>
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

                <asp:Image ID="Image1" runat="server" />
                <div class="marco2">
    <h2 class="text-center"><%: Title %>.INGRESE EL CODIGO DEL ANIMAL</h2>
                    </div>
     <div class="marco2">
    <p>
       

       
        <table class="nav-justified">
            <tr>
                <td class="text-center">&nbsp;</td>
                <td class="text-center"><strong><span style="font-size: x-large">Código</span></strong>:</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Dotted"></asp:TextBox>
                </td>
                <td class="text-center">
                    <asp:Button ID="Button1" runat="server" BorderStyle="Dotted" Height="35px" Text="Buscar" Width="115px" OnClick="Button1_Click" />
                </td>
                <td class="text-center">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px"></td>
                <td style="height: 22px"></td>
                <td style="height: 22px"></td>
                <td style="height: 22px"></td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td class="text-center" style="font-size: x-large; height: 44px">
                    <strong>Alias:</strong></td>
                <td class="text-center" style="height: 44px"><strong><span style="font-size: x-large">Nombre común:</span></strong></td>
                <td class="text-center" style="font-size: x-large; height: 44px"><strong>Nombre cientifico:</strong></td>
                <td class="text-center" style="height: 44px"><strong><span style="font-size: x-large">Sexo:</span></strong></td>
                <td class="text-center" style="height: 44px"></td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelAlias" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelNombreComun" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelNombreCientifico" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="text-center" style="height: 22px">
                    <asp:Label ID="LabelSexo" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td style="height: 22px">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td class="text-center" style="height: 22px">&nbsp;</td>
                <td style="height: 22px">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="height: 22px" colspan="5">
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_historial" DataSourceID="SqlDataSource1" HorizontalAlign="Left" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="Id_historial" HeaderText="Id_historial" InsertVisible="False" ReadOnly="True" SortExpression="Id_historial" />
                            <asp:BoundField DataField="Fecha_diagnostico" HeaderText="Fecha_diagnostico" SortExpression="Fecha_diagnostico" />
                            <asp:BoundField DataField="Motivo_consulta" HeaderText="Motivo_consulta" SortExpression="Motivo_consulta" />
                            <asp:BoundField DataField="Peso" HeaderText="Peso" SortExpression="Peso" />
                            <asp:BoundField DataField="Temperatura" HeaderText="Temperatura" SortExpression="Temperatura" />
                            <asp:BoundField DataField="F.Car." HeaderText="F.Car." SortExpression="F.Car." />
                            <asp:BoundField DataField="F.Res." HeaderText="F.Res." SortExpression="F.Res." />
                            <asp:BoundField DataField="Tllc" HeaderText="Tllc" SortExpression="Tllc" />
                            <asp:BoundField DataField="Mucosas" HeaderText="Mucosas" SortExpression="Mucosas" />
                            <asp:BoundField DataField="Turgencia_piel" HeaderText="Turgencia_piel" SortExpression="Turgencia_piel" />
                            <asp:BoundField DataField="pulso" HeaderText="pulso" SortExpression="pulso" />
                            <asp:BoundField DataField="Anamnesis" HeaderText="Anamnesis" SortExpression="Anamnesis" />
                            <asp:BoundField DataField="Enfermedades_anteriores" HeaderText="Enfermedades_anteriores" SortExpression="Enfermedades_anteriores" />
                            <asp:BoundField DataField="Actitud" HeaderText="Actitud" SortExpression="Actitud" />
                            <asp:BoundField DataField="Condicion_corporal" HeaderText="Condicion_corporal" SortExpression="Condicion_corporal" />
                            <asp:BoundField DataField="Hidratacion" HeaderText="Hidratacion" SortExpression="Hidratacion" />
                            <asp:BoundField DataField="Ojos" HeaderText="Ojos" SortExpression="Ojos" />
                            <asp:BoundField DataField="Oidos" HeaderText="Oidos" SortExpression="Oidos" />
                            <asp:BoundField DataField="Nodulos_linfaticos" HeaderText="Nodulos_linfaticos" SortExpression="Nodulos_linfaticos" />
                            <asp:BoundField DataField="Locomocion" HeaderText="Locomocion" SortExpression="Locomocion" />
                            <asp:BoundField DataField="MEsqueletico" HeaderText="MEsqueletico" SortExpression="MEsqueletico" />
                            <asp:BoundField DataField="Nervioso" HeaderText="Nervioso" SortExpression="Nervioso" />
                            <asp:BoundField DataField="Cardiobascular" HeaderText="Cardiobascular" SortExpression="Cardiobascular" />
                            <asp:BoundField DataField="Digestivo" HeaderText="Digestivo" SortExpression="Digestivo" />
                            <asp:BoundField DataField="Respiratorio" HeaderText="Respiratorio" SortExpression="Respiratorio" />
                            <asp:BoundField DataField="Genitourinario" HeaderText="Genitourinario" SortExpression="Genitourinario" />
                            <asp:BoundField DataField="Problemas_encontrados" HeaderText="Problemas_encontrados" SortExpression="Problemas_encontrados" />
                            <asp:BoundField DataField="Diagnostico_presuntivo" HeaderText="Diagnostico_presuntivo" SortExpression="Diagnostico_presuntivo" />
                            <asp:BoundField DataField="Diagnostico_definitivo" HeaderText="Diagnostico_definitivo" SortExpression="Diagnostico_definitivo" />
                            <asp:BoundField DataField="Resultados" HeaderText="Resultados" SortExpression="Resultados" />
                            <asp:BoundField DataField="Progreso_animal" HeaderText="Progreso_animal" SortExpression="Progreso_animal" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BDZoologicoMinervaConnectionString %>" SelectCommand="sp_listado_diagnostico" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextBox1" DefaultValue="" Name="cod" PropertyName="Text" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
            
        .</p>
          </div>
        <div>

            
     <h2 class="text-center"><%: Title %>.</h2>
          
        <div class="marco2" >
    <p class="text-center"><strong><span style="font-size: x-large">D</span></strong><span style="font-weight: bold"><span style="font-size: x-large">IAGNOSTICO DEL PACIENTE:</span></span><strong><table align="center" class="nav-justified" font-size: larger;">
       
    

           
        
      <tr>
            <td style="width: 205px; height: 31px;"></td>
            <td class="text-center" style="width: 307px; height: 31px;">&nbsp;</td>
            <td style="height: 31px"></td>
            <td style="height: 31px">
                &nbsp;</td>
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
                <asp:Button ID="ButtonGuardar" runat="server" OnClick="ButtonGuardar_Click" Text="Guardar" />
            </td>
            <td class="text-center">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="BotonEditar" runat="server" Text="EDITAR UN DIAGNOSTICO" />
            </td>
            <td class="text-center">
                <asp:Button ID="Button3" runat="server" Height="45px" Text="Cancelar" Width="217px" />
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



        </div>
                </ContentTemplate>
            </asp:UpdatePanel>

           </div>
</asp:Content>
