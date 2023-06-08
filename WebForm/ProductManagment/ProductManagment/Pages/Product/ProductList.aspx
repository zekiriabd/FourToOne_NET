<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/_Layout.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="ProductManagment.Pages.Product.ProductList" %>

<%@ Register Src="~/Pages/Compents/Product.ascx" TagName="ProductComponent" TagPrefix="uc" %>
<%@ Register assembly="DevExpress.Web.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
<div class="d-flex flex-row">
<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>                   
        <uc:ProductComponent  runat="server" 
            ProductId='<%# Eval("Id") %>'
            Name='<%# Eval("Name") %>'
            Comment='<%# Eval("Comment") %>'
            Image='<%# Eval("Image") %>'
            Price='<%# Eval("Price") %>'
            Discount='<%# Eval("Discount") %>'
            Like='0'
            
            />
    </ItemTemplate>
</asp:Repeater>

</asp:Content>