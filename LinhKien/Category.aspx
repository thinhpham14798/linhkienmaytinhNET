<%@ Page Title="" Language="C#" MasterPageFile="~/View.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="LinhKien.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="templatemo_content_right">
        <h1>SẢN PHẨM</h1>
        <hr />
        <asp:datalist id="dataSanPham" runat="server" repeatcolumns="2" repeatdirection="Horizontal">
            <ItemTemplate>
                <div class="templatemo_product_box">
                    <h1>
                        <span><asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSanPham") %>'></asp:Label></span>
                    </h1>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/"+Eval("HinhAnh") %>' Width="100px"  Height="150px"/>
                    <div class="product_info">
                        <p>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label></p>
                        <h3>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Gia")+"đ" %>'></asp:Label></h3>
                        <div class="buy_now_button">
                            <a href='<%# "GioHang.aspx?ProID="+Eval("MaSanPham") %>'>Thêm vào giỏ</a></div>
                        <div class="detail_button">
                            <a href='<%# "ChiTietSanPham.aspx?id="+Eval("MaSanPham") %>'>Xem chi tiết</a></div>
                    </div>
                    <div class="cleaner">
                        &nbsp;</div>
                </div>
                <div class="cleaner_with_width">
                    &nbsp;
                </div>
            </ItemTemplate>
        </asp:datalist>
        
    </div>
</asp:Content>
