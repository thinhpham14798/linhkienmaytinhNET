<%@ Page Title="" Language="C#" MasterPageFile="~/View.Master" AutoEventWireup="true" CodeBehind="GioHangRong.aspx.cs" Inherits="LinhKien.GioHangRong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Giỏ hàng đang trống," ForeColor="Red"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Lime" Font-Size="Large" NavigateUrl="~/index.aspx">Mua hàng</asp:HyperLink>
</asp:Content>
