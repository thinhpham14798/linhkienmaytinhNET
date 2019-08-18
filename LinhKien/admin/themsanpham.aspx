<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ViewAdmin.Master" AutoEventWireup="true" CodeBehind="themsanpham.aspx.cs" Inherits="LinhKien.admin.themsanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tmn">
        <asp:label runat="server" ID="lblThongBao" ForeColor="Red"></asp:label>
        <br>
        </div>
    <div class="title">
        <img src="np.gif" class="ico" alt="icon menu"><b>Thêm sản phẩm mới</b>
    </div>
    <div class="gmenu">
        <p></p>
        <h3>Mã SP</h3>
        <asp:TextBox runat="server" ID="txtMaSP" Enabled="False"></asp:TextBox>
        <br />
        <small>
            <p>
                Mã này tự sinh, bạn không cần phải ghi vào</b></small><p></p>
        <h3>Tên sản phẩm</h3>
        <asp:TextBox runat="server" ID="txtTenSP"></asp:TextBox><br>

        <p></p>
        <h3>Giá bán</h3>
        <asp:TextBox runat="server" ID="txtGiaBan"></asp:TextBox><br>

        <p></p>
        <h3>Số lượng bán</h3>
        <asp:TextBox runat="server" ID="txtSLBan"></asp:TextBox><br>

        <p></p>
        <h3>Chuyên Mục</h3>
        <br>
        <asp:DropDownList ID="chuyenmuc" runat="server" Width="249px" OnSelectedIndexChanged="chuyenmuc_SelectedIndexChanged"></asp:DropDownList>
        <p></p>
        <h3>Mô tả</h3>
        <asp:TextBox runat="server" ID="txtMoTa" Height="168px" Width="659px"></asp:TextBox><br>

        <p></p>
        <h3>Hình Ảnh</h3>
        <asp:Image ID="Image1" runat="server" Height="150px" Width="100px" /><br /><asp:FileUpload ID="FileUpload1" runat="server" Width="348px" Height="27px" />
        &nbsp;<br>

        <p></p>
        <p>
            <asp:Button runat="server" Text="Thêm" ID="btnThem" OnClick="btnThem_Click" />
        </p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUpload1" Display="None" ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;"></asp:RequiredFieldValidator>
                    
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
</asp:Content>
