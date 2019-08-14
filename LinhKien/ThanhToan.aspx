<%@ Page Title="" Language="C#" MasterPageFile="~/View.Master" AutoEventWireup="true" CodeBehind="ThanhToan.aspx.cs" Inherits="LinhKien.ThanhToan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="templatemo_content_right">
        <h1>Xác nhận đơn hàng</h1>
        <asp:GridView ID="gvDatHang" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="100%">
            <Columns>
                <asp:BoundField HeaderText="Mã" DataField="IdSP" />
                <asp:BoundField HeaderText="Tên sản phẩm" DataField="tenSP" />
                <asp:BoundField HeaderText="Giá" DataField="Gia" />
                <asp:BoundField HeaderText="Số lượng" DataField="SoLuong" />
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
        <asp:Label ID="lblTongTien" runat="server" Text="Tổng tiền: " Font-Bold="True" ForeColor="Red"></asp:Label><br />
        <h1>Thông tin thanh toán</h1>
        <div style="margin: 20px">
            <label>Họ Tên:</label>
            <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtHoTen" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <div style="margin-bottom: 20px"></div>
            <label>Điện Thoại:</label>
            <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSDT" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <div style="margin-bottom: 20px"></div>
            <label>Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            <div style="margin-bottom: 20px"></div>
            <label>Địa chỉ giao hàng:</label>
            <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDiaChi" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <div style="margin-bottom: 20px"></div>
            <label>Yêu cầu bổ sung:</label>
            <asp:TextBox ID="txtNote" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <div style="margin-bottom: 20px"></div>
            <asp:Button ID="Button1" runat="server" Text="Gửi đơn hàng" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>
