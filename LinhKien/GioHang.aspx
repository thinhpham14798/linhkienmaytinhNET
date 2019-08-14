<%@ Page Title="" Language="C#" MasterPageFile="~/View.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="LinhKien.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="templatemo_content_right">
        <h1>GIỎ HÀNG</h1>
        <hr />
        <asp:GridView ID="gvGioHang" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="100%" OnRowCommand="gvGioHang_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Mã" DataField="IdSP" />
                <asp:BoundField HeaderText="Tên sản phẩm" DataField="tenSP" />
                <asp:BoundField HeaderText="Giá" DataField="Gia" />
                <asp:BoundField HeaderText="Số lượng" DataField="SoLuong" />
                <asp:BoundField HeaderText="Thành tiền" DataField="ThanhTien" />
                <asp:TemplateField HeaderText="Thao tác">
                        <ItemTemplate>
                            <asp:ImageButton ID="btnDel" runat="server" CausesValidation="false" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Xoa" ImageUrl="~/admin/del.png" OnClientClick="return confirm(&quot;Bạn chắc chắn muốn xóa chứ?&quot;);" />
                        </ItemTemplate>
                </asp:TemplateField>
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
        <hr />
        <div style="display: block">
            <asp:Label ID="lblTongTien" runat="server" Text="Tổng tiền: " Font-Bold="True" ForeColor="Red"></asp:Label>
            <div style="float: right">
                <asp:Button ID="Button1" runat="server" Text="Thanh toán" OnClick="Button1_Click" /></div>

        </div>
    </div>
</asp:Content>
