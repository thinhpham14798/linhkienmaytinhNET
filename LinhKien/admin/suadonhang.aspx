<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ViewAdmin.Master" AutoEventWireup="true" CodeBehind="suadonhang.aspx.cs" Inherits="LinhKien.admin.suadonhang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tmn">
        <asp:label runat="server" ID="lblThongBao" ForeColor="Red"></asp:label>
        <br>
        </div>
    <div class="title">
        <img src="np.gif" class="ico" alt="icon menu"><b>Cập nhật đơn hàng</b>
    </div>
    <div class="gmenu">
        <p></p>
        <h3>Mã DH</h3>
        <asp:TextBox runat="server" ID="txtMaDH" Enabled="False"></asp:TextBox>
        <br />
        <small>
            <p>
                Mã này tự sinh, bạn không cần phải ghi vào</b></small><p></p>
         <h3>Ngày đặt</h3>
        <asp:TextBox runat="server" ID="txtNgayDat" Enabled="false" ></asp:TextBox><br>

        <p></p>
        <h3>Người đặt</h3>
        <asp:TextBox runat="server" ID="txtNguoiDat" Enabled="False" ></asp:TextBox><br>

        <p></p>
        <h3>Số điện thoại</h3>
        <asp:TextBox runat="server" ID="txtSDT" Enabled="False"></asp:TextBox><br>

        <p></p>
        <h3>Địa chỉ email</h3>
        <asp:TextBox runat="server" ID="txtEmail" Enabled="False"></asp:TextBox><br>

        <p></p>
        <h3>Địa chỉ giao</h3>
        <asp:TextBox runat="server" ID="txtDiaChi" Enabled="False"></asp:TextBox><br>

        <p></p>
        <h3>Ghi chú:</h3>
        <asp:TextBox runat="server" ID="txtGhiChu" Enabled="False"></asp:TextBox><br>

        <p></p>
        <h3>Danh sách sản phẩm</h3>
        <asp:GridView ID="gvDatHang" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="100%">
            <Columns>
                <asp:BoundField HeaderText="Mã" DataField="MaSP" />
                <asp:BoundField HeaderText="Tên sản phẩm" DataField="TenSanPham" />
                <asp:BoundField HeaderText="Giá" DataField="Gia" />
                <asp:BoundField HeaderText="Số lượng" DataField="SL" />
                <asp:BoundField HeaderText="Thành tiền" DataField="ThanhTien" />

            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <p></p>
        <h3>Tổng tiền</h3>
        <asp:TextBox runat="server" ID="txtTongTien" Enabled="False"></asp:TextBox><br>

        <p></p>
        <h3>Trạng thái</h3>
        <br>
        <asp:DropDownList ID="trangthai" runat="server" Width="249px"></asp:DropDownList>
        <p></p>
        <p></p>
        <p>
            <asp:Button runat="server" Text="Sửa" ID="btnSua" OnClick="btnSua_Click" />
        </p>
    </div>
</asp:Content>
