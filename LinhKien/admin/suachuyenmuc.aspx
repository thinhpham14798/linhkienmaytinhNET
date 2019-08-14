<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ViewAdmin.Master" AutoEventWireup="true" CodeBehind="suachuyenmuc.aspx.cs" Inherits="LinhKien.admin.suachuyenmuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tmn">
        <asp:label runat="server" ID="lblThongBao" ForeColor="Red"></asp:label>
        <br>
        </div>
    <div class="title">
        <img src="np.gif" class="ico" alt="icon menu"><b>Sửa danh mục</b>
    </div>
    <div class="gmenu">
        <p></p>
        <h3>Mã danh mục</h3>
        <asp:textbox runat="server" ID="txtMaDanhMuc" Enabled="False"></asp:textbox>
        <br />
        <small>
            <p>
                Mã này tự sinh, bạn không cần phải ghi vào</p></small><p></p>
        <h3>Tên danh mục</h3>
        <asp:textbox runat="server" ID="txtTenDanhMuc"></asp:textbox>
        <br>
        <small>Viết tiếng việt là tốt nhất.<br>
        </small>
        <p></p>
        <p>
            <asp:button runat="server" text="Sửa" ID="btnSua" OnClick="btnSua_Click" />
        </p>
    </div>
</asp:Content>
