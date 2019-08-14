<%@ Page Title="" Language="C#" MasterPageFile="~/View.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="LinhKien.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="templatemo_content_right">

        <h1>
            <asp:Label ID="lblTenSP" runat="server" Text="Label"></asp:Label></h1>
        <div class="image_panel">
            <asp:Image ID="img" runat="server" Height="150px" Width="100px"  /></div>
            <h2>
                <asp:Label ID="lblGia" runat="server" Text="Giá bán"></asp:Label></h2>
        <ul>
            <li>Ngày mở bán: <asp:Label ID="lblNgayBan" runat="server" Text="Label"></asp:Label></li>
            <li>Số lượng còn: <asp:Label ID="lblSoLuongCon" runat="server" Text="Số lượng còn"></asp:Label></li>
            <li>Số lương đã bán: <asp:Label ID="lblSoLuongDaBan" runat="server" Text="Số lượng đã bán"></asp:Label></li>
        </ul>
        <div class="buy_now_button">
            <asp:HyperLink ID="HyperLink1" runat="server">Mua ngay</asp:HyperLink>
        </div>
        <p>
            <asp:Label ID="lblMoTa" runat="server" Text="MoTa"></asp:Label></p>
        <div class="cleaner_with_height">&nbsp;</div>
    </div> <!-- end of content right -->
    
    	<div class="cleaner_with_height">&nbsp;</div>
</asp:Content>
