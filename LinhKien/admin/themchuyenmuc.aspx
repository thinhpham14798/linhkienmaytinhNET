<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ViewAdmin.Master" AutoEventWireup="true" CodeBehind="themchuyenmuc.aspx.cs" Inherits="LinhKien.admin.themchuyenmuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tmn">
        <asp:label runat="server" ID="lblThongBao" ForeColor="Red"></asp:label>
        <br>
        </div>
    <div class="title">
        <img src="np.gif" class="ico" alt="icon menu"><b>Thêm danh mục mới</b>
    </div>
    <div class="gmenu">
        <p></p>
        <h3>Mã danh mục</h3>
        <asp:textbox runat="server" ID="txtMaDanhMuc" Enabled="False"></asp:textbox>
        <br />
        <small>
            <p>
                Mã này tự sinh, bạn không cần phải ghi vào</b></small><p></p>
        <h3>Tên danh mục</h3>
        <asp:textbox runat="server" ID="txtTenDanhMuc"></asp:textbox>
        <br>
        <small>Viết tiếng việt là tốt nhất.<br>
        </small>
        <p></p>
        <p>
            <asp:button runat="server" text="Thêm" ID="btnThem" OnClick="btnThem_Click" />
        </p>
    </div>
</asp:Content>
