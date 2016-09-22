<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Educacion.aspx.cs" Inherits="ZOOMINERVA6.Educacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
     <style type="text/css">

           .marco {
               background-image: url('images/beige2.jpg');
               border-radius: 20px;
               padding: 23px;
               margin: 23px;
               width: 70%;
               
    
    
           }
              </style>

     <style type="text/css">

           .fondo {
               background-image: url('images/madera4.jpg');
               background-attachment :fixed;
             
           }
             </style>

            <style type="text/css">
  .size1of3 { float:left; width: 50%; 
              
  }

                .auto-style2 {
                    font-size: xx-large;
                }
                .auto-style3 {
                    height: 22px;
                }
                .auto-style5 {
                    text-align: center;
                    font-size: large;
                }
        </style>
     <h2><%: Title %>.<asp:Image ID="Image2" runat="server" />
    </h2>
    <div class="fondo">

   
     <div class="text-center" style="background-image: url('images/beige2.jpg');">
        <tr>
            <td style=" background-image: url('images/beige2.jpg'); color: #003399;" class="auto-style11" colspan="4"><span  style="font-family: 'Comic Sans MS'"><span class="auto-style2">PAQUETES EDUCATIVOS</td>
      
                </td>
                  </tr>
                
         </span>
                
    </div>
  
       
        
<asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
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
               
                
            </div>
            <div>

            </div>
             
        </ItemTemplate>
    </asp:Repeater>



   
        &nbsp;
               &nbsp;
               &nbsp;
               &nbsp;
          &nbsp;
               &nbsp;
               &nbsp;
               &nbsp;
         
   
           </div>
     </span>
</asp:Content>
