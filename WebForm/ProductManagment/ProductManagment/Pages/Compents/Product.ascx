<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Product.ascx.cs" Inherits="ProductManagment.Pages.Compents.Product"%>

<div class="card p2" style="width: 18rem;">
    <img class="card-img-top" src="<%=Image%>" alt="Card image cap" width="50px">
    <div class="card-body">
    <h5 class="card-title"><%=Name%></h5>
    <p class="card-text"><%=Comment%></p>
     <%if (Discount > 0){ %>
            <span class="text-decoration-line-through"><%=Price%>€</span>
            <span class="text-danger m-2"><%=(Price * Discount / 100)%>€</span>
        <% } else { %>
            <span><%=Price%>€</span>
        <%}%>
  </div>
  </div>
