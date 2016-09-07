<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Educacion.aspx.cs" Inherits="ZOOMINERVA6.Educacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.<asp:Image ID="Image2" runat="server" />
    </h2>
     <style type="text/css">

           .marco {
               border-left: 6px solid green;
    background-color: lightgrey;
    
           }
              </style>

            <style type="text/css">
  .size1of3 { float:left; width: 50%; }
                .auto-style1 {
                    background-color: #006600;
                }
        </style>


    
    <p>
   
        <table class="nav-justified">
            <tr>
                <td class="text-center" colspan="5"><strong style="font-family: Arial, Helvetica, sans-serif; font-size: 35px"><span class="auto-style1">PAQUETES EDUCATIVOS</span></strong></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="text-center">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            </table>
<asp:Repeater ID="Repeater1" runat="server" >
        <ItemTemplate>
            <div class="size1of3">
<table class="marco">
    
    <tr><th style="background-color: #C0C0C0">IMAGEN  <%#Eval("codigo") %> </th></tr>
    <tr><td><strong>PAQUETE:           </pre> </strong></td><td><%#Eval("NOMBRE") %> </td></tr>
    <tr><td><strong>TEMA </strong></td><td><%#Eval("TEMA") %> </td></tr>
    <tr><td><strong>OBJETIVOS</strong></td><td><%#Eval("Objetivos") %> </td></tr>
    <tr><td><strong>DONACION POR PERSONA</strong></td><td><%#Eval("DONACIÓN") %> </td></tr>
    <tr><td><strong>¿QUE INCLUYE?  </strong></td><td><%#Eval("Incluye") %> </td></tr>
    
</table>
                 <tr><td><pre style="background-color:white"> 

                     

             </pre></td></tr>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    </p>
</asp:Content>
