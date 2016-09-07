<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="ZOOMINERVA6.Noticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.<asp:Image ID="Image2" runat="server" />
</h2>
    <p style="height: 30px;" class="text-left">
        <span style="font-size: larger"><strong>.</strong></span></p>
    
    <style type="text/css">
  .size1of3 { float: left; width: 33%; }
        </style>

    <asp:Repeater ID="Repeater1" runat="server" >
        <ItemTemplate>
            <div class="size1of3">
<table>
    <tr><th style="background-color: #C0C0C0">IMAGEN  <%#Eval("Imagen") %> </th></tr>
    <tr><td><strong> Noticia:           </pre> </strong></td><td><%#Eval("Titulo_noticia") %> </td></tr>
    <tr><td><strong>Descripción </strong></td><td><%#Eval("Descripcion") %> </td></tr>
    <tr><td><strong>¿Cuando será?</strong></td><td><%#Eval("fecha") %> </td></tr>
    
   
</table>
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
