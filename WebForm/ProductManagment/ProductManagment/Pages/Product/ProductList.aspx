<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/_Layout.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="ProductManagment.Pages.Product.ProductList" %>
<%@ Register Src="~/Pages/Compents/Product.ascx" TagName="ProductComponent" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:GridView ID="GVProducts" runat="server"></asp:GridView> --%>  

    <%--<%foreach(var prodect in Products) { %>
       <table>
           <tr><td><%=prodect.Name%></td></tr>
       </table>
    <%} %>--%>

<div class="d-flex flex-row">
<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>                   
        <uc:ProductComponent  runat="server" 
            Name='<%# Eval("Name") %>'
            Comment='<%# Eval("Comment") %>'
            Image='<%# Eval("Image") %>'
            Price='<%# Eval("Price") %>'
            Discount='<%# Eval("Discount") %>'
            />
    </ItemTemplate>
</asp:Repeater>
     

  <%--<div class="card p2" style="width: 18rem;">
    <img class="card-img-top" src="<%=prodect.Image%>" alt="Card image cap" width="50px">
    <div class="card-body">
    <h5 class="card-title"><%=prodect.Name%></h5>
    <p class="card-text"><%=prodect.Comment%></p>
    <p><%=prodect.Price%></p>
  </div>
  </div>
    <%} %>--%>
  
 </div>
</asp:Content>
