<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Product.ascx.cs" Inherits="ProductManagment.Pages.Compents.Product"%>
<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<div class="card p2" style="width: 18rem;">
    <img class="card-img-top" src="<%=Image%>" alt="Card image cap" width="50px">
    <div class="card-body">
    <h5 class="card-title"><%=Name%></h5>
         <div class="clearfix mbr-3 col-2">
               <dx:ASPxCallbackPanel runat="server" ID="ASPxCallbackPanel1" Height="0"
                   ClientInstanceName="CallbackPanel" RenderMode="Table" OnCallback="ASPxCallbackPanel1_Callback">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent3" runat="server">
                                <dx:ASPxLabel ClientInstanceName="lbLike" ID="lbLike" runat="server" class="float-start badge rounded-pill bg-primary"             />
                              </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxCallbackPanel>
         </div>
             <p class="card-text"><%=Comment%></p>
     <%if (Discount > 0){ %>
            <span class="text-decoration-line-through"><%=Price%>€</span>
            <span class="text-danger m-2"><%=(Price * Discount / 100)%>€</span>
        <% } else { %>
            <span><%=Price%>€</span>
        <%}%>
  </div>
     <div class="card-footer">
            <div class="btn-ground text-center pb-1">
                <button type="button" class="btn btn-primary" onclick="@AddProduct">Ajouter au panier</button>
                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="J'aime" AutoPostBack="false" class="btn btn-primary">
                    <ClientSideEvents Click="function(s, e) { CallbackPanel.PerformCallback();}"/>
                </dx:ASPxButton>              
            </div>
        </div>
  </div>
