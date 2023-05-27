<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/_Layout.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="ProductManagment.Pages.Product.ProductList" %>

<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Src="~/Pages/Compents/Product.ascx" TagName="ProductComponent" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <dx:ASPxGridView ID="GVProducts" runat="server" Width="100%"
        KeyFieldName="Id" PreviewFieldName="Notes" EnableRowsCache="False">
        <Settings ShowPreview="true" />
        <SettingsPager PageSize="3" />

        <Columns>
            <dx:GridViewDataColumn FieldName="Name" VisibleIndex="1" />
            <dx:GridViewDataColumn FieldName="Comment" VisibleIndex="4" />
            <dx:GridViewDataColumn FieldName="Price" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="Discount" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="Image" VisibleIndex="3" >
             <DataItemTemplate>
                <dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Value='<%# Eval("Image") %>' />
             </DataItemTemplate>
            </dx:GridViewDataColumn>
        </Columns>
        
    </dx:ASPxGridView>
</asp:Content>