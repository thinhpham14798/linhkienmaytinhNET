﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="LinhKien.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="templatemo_content_right">

        <h1>Book Title <span>(by author name)</span></h1>
        <div class="image_panel">
            <img src="images/templatemo_image_02.jpg" alt="CSS Template" width="100" height="150" /></div>
        <h2>Read the lessons - Watch the videos - Do the exercises</h2>
        <ul>
            <li>By Deke <a href="#">McClelland</a></li>
            <li>January 2024</li>
            <li>Pages: 498</li>
            <li>ISBN 10: 0-496-91612-0 | ISBN 13: 9780492518154</li>
        </ul>
        <div class="buy_now_button">
            <a href='<%# "ThanhToan.aspx?add="+Eval("MaSanPham") %>'>Mua ngay</a>
        </div>
                        <div class="detail_button">
                            <a href='<%# "ChiTietSanPham.aspx?id="+Eval("MaSanPham") %>'>Xem chi tiết</a></div>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus nec dui. Donec nec neque ut quam sodales feugiat. Nam sodales, pede vel dapibus lobortis, ipsum diam molestie risus, a vulputate risus nisl pulvinar lacus.</p>

        <p>Donec at arcu. Nunc aliquam, dolor vitae sollicitudin lacinia, nibh orci sagittis diam, dignissim sodales dui erat nec eros. Fusce quis enim. Aenean eleifend, neque hendrerit elementum sodales, odio erat sagittis quam, sed tempor orci magna vitae tellus. Proin dui mauris, tempor eget, pulvinar sed, pretium sit amet, dui. Proin vulputate justo et quam.</p>

        <p>In fermentum, eros ac tincidunt aliquam, elit velit semper nunc, a tincidunt orci lectus a arcu. Nullam commodo, arcu non facilisis imperdiet, felis lectus tempus felis, vitae volutpat augue ante quis leo. Aliquam tristique dolor ac odio. Sed consectetur, lacus et dictum tristique, odio neque elementum ante, nec eleifend leo dolor vel tortor.</p>

        <div class="cleaner_with_height">&nbsp;</div>
    </div> <!-- end of content right -->
    
    	<div class="cleaner_with_height">&nbsp;</div>
</asp:Content>
